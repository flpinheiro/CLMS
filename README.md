# CLMS
 Application devenloped to help small business to mannager appointments for the customers.

## initial concept

*   Classes
**  Usuário
	N° Telefone
	senha
	tipo
	permissões
	nome
**	Cadeira
    Usuario(Barbeiro)
	Fila
**	Serviços
	descrição
	tempo
	preço
	multa(%)
**	Fila
    Usuario(cliente)
	Serviços
	dataAtual(d/m/y h:i:s)
**  FilaBackup
	Usuario
	Serviços
	dataFila(d/m/y)
**	Configuracao
	dias ativos
	dias de fila ativa
	tempo para aviso(definição do cliente)
	tempo limite de atraso(definição do barbeiro)
	horario de funcionamento