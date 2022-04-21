import "./App.css";
import { useState, useEffect } from "react";
import AtividadeForm from "./Components/AtividadeForm";
import AtividadeLista from "./Components/AtividadeLista";

function App() {
  const [index, setIndex] = useState(0);
  const [atividades, setAtividades] = useState([]);
  const [atividade, setAtividade] = useState({ id: 0 });

  useEffect(() => {
    atividades.length <= 0
      ? setIndex(1)
      : setIndex(
          Math.max.apply(
            Math,
            atividades.map((item) => item.id)
          ) + 1
        );
  }, [atividades]);

  function addAtividade(ativ) {
    setAtividades([...atividades, { ...ativ, id: index }]);
  }

  function cancelarAtividade() {
    setAtividade({ id: 0 });
  }

  function atualizarAtividade(ativ) {
    console.log(ativ);
    setAtividades(
      atividades.map((item) => (item.id === ativ.id ? ativ : item))
    );
    setAtividade({ id: 0 });
  }

  function deletarAtividade(id) {
    const atividadeFiltrada = atividades.filter(
      (atividade) => atividade.id !== id
    );

    setAtividades([...atividadeFiltrada]);
  }

  function pegarAtividade(id) {
    const atividade = atividades.filter((atividade) => atividade.id === id);

    setAtividade(atividade[0]);
  }

  return (
    <>
      <AtividadeForm
        atividades={atividades}
        ativSelecionada={atividade}
        atualizarAtividade={atualizarAtividade}
        cancelarAtividade={cancelarAtividade}
        addAtividade={addAtividade}
      />
      <AtividadeLista
        atividades={atividades}
        pegarAtividade={pegarAtividade}
        deletarAtividade={deletarAtividade}
      />
    </>
  );
}

export default App;
