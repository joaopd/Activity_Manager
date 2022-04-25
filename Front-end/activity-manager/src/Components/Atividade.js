export default function Atividade(props) {
  function prioridadeLabel(param) {
    switch (param) {
      case 1:
        return "Baixa";
      case 2:
        return "Normal";
      case 3:
        return "Alta";

      default:
        return "Não Definido";
    }
  }

  function prioridadeStyle(param, icone) {
    switch (param) {
      case 1:
        return icone ? "smile" : "success";

      case 2:
        return icone ? "meh" : "dark";

      case 3:
        return icone ? "frown" : "danger";

      default:
        return "Não Definido";
    }
  }

  return (
    <div
      className={
        "card mb-2 shadow-sm border-" + prioridadeStyle(props.ativ.prioridade)
      }
    >
      <div className="card-body">
        <div className="d-flex justify-content-between">
          <h5 className="card-title">
            <span className="badge bg-secondary me-1">
              {props.ativ.id}
            </span>
            {props.ativ.titulo}
          </h5>
          <h6>
            Prioridade:
            <span
              className={"ms-1 text-" + prioridadeStyle(props.ativ.prioridade)}
            >
              <i
                className={
                  "me-1 far fa-" + prioridadeStyle(props.ativ.prioridade, true)
                }
              />
              {prioridadeLabel(props.ativ.prioridade)}
            </span>
          </h6>
        </div>
        <p className="card-text">
          {props.ativ.descricao}
        </p>
        <div className="d-flex justify-content-end pb-2 m-0 border-top">
          <button
            className="btn btn-sm btn-outline-primary me-2"
            onClick={() => props.pegarAtividade(props.ativ.id)}
          >
            <i className="fas fa-pen me-2" />
            editar
          </button>
          <button
            className="btn btn-sm btn-outline-danger"
            onClick={() => props.handleConfirmeModal(props.ativ.id)}
          >
            <i className="fas fa-trash me-2" />
            deletar
          </button>
        </div>
      </div>
    </div>
  );
}
