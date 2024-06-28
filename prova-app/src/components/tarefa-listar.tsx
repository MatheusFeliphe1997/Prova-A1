import { useEffect, useState } from "react";

import { Link } from "react-router-dom";
import { Tarefa } from "../models/Tarefa";

function ProdutoListar() {
  const [produtos, setProdutos] = useState<Tarefa[]>([]);

  useEffect(() => {
    carregarProdutos();
  }, []);

  function carregarProdutos() {
    //FETCH ou AXIOS
    fetch("http://localhost:5225/api/produto/listar")
      .then((resposta) => resposta.json())
      .then((tarefa: Tarefa[]) => {
        console.table(tarefa);
        setProdutos(tarefa);
      });
  }

  function deletar(id: string) {
    fetch(`http://localhost:5225/api/produto/deletar/${id}`, {
      method: "DELETE",
    })
      .then((resposta) => resposta.json())
      .then((dados) => {
        console.log(dados);
        carregarProdutos();
      });
  }

  return (
    <div>
      <h1>Listar Produtos</h1>
      <table border={1}>
        <thead>
          <tr>
            <th>#</th>
            <th>Nome</th>
            <th>Descrição</th>
            <th>Quantidade</th>
            <th>Valor</th>
            <th>Criado Em</th>
            <th>Deletar</th>
            <th>Alterar</th>
          </tr>
        </thead>
        <tbody>
          {produtos.map((produto) => (
            <tr key={produto.id}>
              <td>{produto.id}</td>
              <td>{produto.nome}</td>
              <td>{produto.descricao}</td>
              <td>{produto.quantidade}</td>
              <td>{produto.valor}</td>
              <td>{produto.criadoEm}</td>
              <td>
                <button
                  onClick={() => {
                    deletar(produto.id!);
                  }}
                >
                  Deletar
                </button>
              </td>
              <td>
                <Link to={`/pages/produto/alterar/${produto.id}`}>
                  Alterar
                </Link>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default TarefaListar;
