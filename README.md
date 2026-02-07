# Gerenciador-de-livraria

Construir uma API REST em .NET para gerenciar livros de uma livraria, com CRUD completo, validações, documentação via Swagger e herança entre classes para organizar o domínio.



Instruções

Estrutura, regras e requisitos do projeto

1\. Requisitos

Deve ser possível criar um livro;

Deve ser possível visualizar todos os livros que foram criados;

Deve ser possível visualizar um livro em específico;

Deve ser possível editar informações de um livro;

Deve ser possível excluir um livro.



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



2\. Desenvolvendo o projeto

Para desenvolver esse projeto, recomendamos utilizar as principais tecnologias que utilizamos durante o desenvolvimento do primeiro módulo da formação.

Caso você tenha alguma dificuldade você pode ir no nosso fórum e deixar sua dúvida por lá!

Após terminar o desafio, caso você queira, você pode tentar dar o próximo passo e deixar a aplicação com a sua cara. Tente mudar o layout, cores, ou até adicionar novas funcionalidades para ir além! 🚀





Tarefas

Use este checklist para ajudar a organizar a sua entrega

0 de 15



Criar projeto .NET;

Habilitar Swagger;

Configura pasta: Controllers, Models, entre outras;

Criar modelo Book com campo: título, autor, gênero, preço, estoque.

Implementar validações básicas (campos obrigatórios, tamanhos, duplicidade).

Criar endpoints CRUD.

Implementar POST para criar livro.

Implementar GET para listar livro.

Implementar GET para buscar por id o livro.

Implementar PUT para atualizar livro.

Implementar DELETE para excluir livro.

Documentar endpoints no Swagger com exemplos.

Testar manualmente todos os cenários(validações, sucesso, erros).

Subir o código do Desafio no GitHub para ter um projeto a mais no portifólio.

Escrever Readme explicando como rodar e visualizar o portifólio.

