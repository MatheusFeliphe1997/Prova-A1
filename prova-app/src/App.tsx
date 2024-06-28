import React from "react";

import { BrowserRouter, Link, Routes, Route } from "react-router-dom";
import TarefaListar from "./components/tarefa-listar";
import TarefaCadastrar from "./components/tarefa-cadastrar";


function App() {
  return (
    <div>
      <BrowserRouter>
        <nav>
          <ul>
            <li>
              <Link to={"/"}>Home</Link>
            </li>
            <li>
              <Link to={"/pages/produto/listar"}>
                Listar Produtos{" "}
              </Link>
            </li>
            <li>
              <Link to={"/pages/produto/cadastrar"}>
                Cadastrar Produtos{" "}
              </Link>
            </li>
            <li>
              <Link to={"/pages/cep/consultar"}>Consultar CEP </Link>
            </li>
          </ul>
        </nav>
        <Routes>
          <Route path="/" element={<TarefaListar />} />
          <Route
            path="/pages/produto/listar"
            element={<TarefaListar />}
          />
          <Route
            path="/pages/produto/cadastrar"
            element={<TarefaCadastrar />}
          />
          <Route
            path="/pages/cep/consultar"
            element={<CepConsultar />}
          />
          <Route
            path="/pages/produto/alterar/:id"
            element={<TarefaAlterar />}
          />
        </Routes>
        <footer>
          <p>Desenvolvido por Diogo Steinke Deconto</p>
        </footer>
      </BrowserRouter>
    </div>
  );
}

export default App;
