import { useState, useEffect } from "react";

const atividadeInicial = {
  id: 0,
  titulo: "",
  prioridade: 0,
  descricao: ""
};

export default function AtividadeForm(props) {
  const [atividade, setAtividade] = useState(atvidadeAtual());
  useEffect(() => {
    if (props.ativSelecionada.id !== 0) {
      setAtividade(props.ativSelecionada);
    }
  }, [props.ativSelecionada]);

  const inputTextHandler = (e) => {
    const { name, value } = e.target;

    setAtividade({ ...atividade, [name]: value });
  };
  function atvidadeAtual() {
    if (props.ativSelecionada.id !== 0) {
      return props.ativSelecionada;
    } else {
      return atividadeInicial;
    }
  }
  const handlerCancelar = (e) => {
    e.preventDefault();

    props.cancelarAtividade();

    setAtividade(atividadeInicial);
  };

  const handlerSubmit = (e) => {
    e.preventDefault();

    if (props.ativSelecionada.id !== 0) props.atualizarAtividade(atividade);
    else props.addAtividade(atividade);

    setAtividade(atividadeInicial);
  };

  return (
    <>
      <h1>Atvidade {atividade.id !== 0 ? atividade.id : ""}</h1>
      <form className="row g-3" onSubmit={handlerSubmit}>
        <div className="col-md-6">
          <label className="form-label">Título</label>
          <input
            type="text"
            className="form-control"
            name="titulo"
            onChange={inputTextHandler}
            value={atividade.titulo}
          />
        </div>
        <div className="col-md-6">
          <label className="form-label">Prioridade</label>
          <select
            className="form-select"
            name="prioridade"
            onChange={inputTextHandler}
            value={atividade.prioridade}
          >
            <option defaultValue="0">Selecione...</option>
            <option value="1">Baixa</option>
            <option value="2">Normal</option>
            <option value="3">Alta</option>
          </select>
        </div>

        <div className="col-md-12">
          <label className="form-label">Descrição</label>
          <textarea
            type="text"
            className="form-control"
            name="descricao"
            onChange={inputTextHandler}
            value={atividade.descricao}
          />
          <hr />
        </div>
        <div className="col-12 mt-0">
          {atividade.id === 0 ? (
            <button className="btn btn-outline-secondary" type="subimit">
              <i className="fas fa-plus me-2s" />
              Atividade
            </button>
          ) : (
            <>
              <button className="btn btn-outline-success me-2" type="subimit">
                <i className="fas fa-plus me-2s" />
                Salvar
              </button>
              <button
                className="btn btn-outline-warning"
                onClick={handlerCancelar}
              >
                <i className="fas fa-plus me-2s" />
                Cancelar
              </button>
            </>
          )}
        </div>
      </form>
    </>
  );
}
