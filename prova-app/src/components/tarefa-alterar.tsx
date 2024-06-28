import { useEffect, useState } from "react";
import {useNavigate, useParams } from "react-router-dom";
import { Tarefa } from "../models/Tarefa";

function TarefaAlterar(){

    const navigate = useNavigate();
    useEffect(() => {
        if (id) {
          fetch(`http://localhost:5000/api/produto/buscar/${id}`)
            .then((resposta) => resposta.json())
            .then((produto: Produto) => {
              setNome(produto.nome);
              setDescricao(produto.descricao);
              setQuantidade(produto.quantidade.toString());
              setValor(produto.valor.toString());
            });
        }
      }, []);
}