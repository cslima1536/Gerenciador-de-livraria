# Gerenciador-de-livraria

Construir uma API REST em .NET para gerenciar livros de uma livraria, com CRUD completo, validações, documentação via Swagger e herança entre classes para organizar o domínio.

Instruções

Estrutura, regras e requisitos do projeto

1\. Requisitos

Deve ser possível criar um livro;

Deve ser possível visualizar todos os livros que foram criados;

Deve ser possível visualizar um livro em específico;

Deve ser possível editar informações de um livro;

Deve ser possível excluir um livro.



Campos obrigatórios


Campo	Tipo	Obrigatório	Regras/Validações

id	GUID	Sim	Gerado automaticamente pelo sistema.

title	string	Sim	Deve ter entre 2 e 120 caracteres.

author	string	Sim	Deve ter entre 2 e 120 caracteres.

genre	string	Sim	Deve ser um dos valores válidos: ficção, romance, mistério, ....

price	decimal	Sim	Deve ser maior ou igual a 0.

stock	int	Sim	Deve ser maior ou igual a 0.


Regras de negócio

title e author não devem existir duplicados;

price não pode ser negativo;

stock não pode ser negativo;

genre deve estar numa lista de gêneros válidos.

Quando o livro é criado, preencher CreatedAt em alterações, atualizar UpdatedAt.

Endpoints

Crie todos os endpoints necessários;

Método	Endpoint	Descrição

POST	/api/books	Criar um novo livro.

GET	/api/books	Listar todos os livros (com filtros opcionais).

GET	/api/books/{id}	Buscar um livro pelo ID.

PUT	/api/books/{id}	Atualizar informações de um livro.

DELETE	/api/books/{id}	Excluir um livro da livraria.

Status Code

Retorne status code apropriados pra cada situação:

| Status | Descrição              |

| ------ | ---------------------- |

| 200    | Sucesso                |

| 201    | Recurso criado         |

| 204    | Operação sem retorno   |

| 400    | Dados inválidos        |

| 404    | Recurso não encontrado |

| 409    | Conflito (duplicidade) |

| 500    | Erro interno           |
