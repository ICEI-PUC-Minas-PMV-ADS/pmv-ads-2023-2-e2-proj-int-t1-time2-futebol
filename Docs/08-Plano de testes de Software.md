# Plano de Testes de Software

**Objetivo:**
O objetivo deste plano de teste é garantir que a aplicação destinada a olheiros de futebol, treinadores e jogadores tenha um desempenho adequado, fornecendo análises precisas e relevantes sobre o desempenho dos atacantes das séries B e C de clubes do Sudeste.

**Escopo:**
O teste será realizado para validar as funcionalidades relacionadas à coleta, análise e apresentação de dados de desempenho de atacantes, garantindo a precisão e confiabilidade das análises feitas pela aplicação.

| **Caso de Teste** 	| **CT-01 - Teste de Coleta de Dados dos Atacantes** 	|
|:---:	|:---:	|
| Requisito Associado | RF-003 - O site deve realizar a coleta de dados dos atacantes de forma precisa. |
|	Caso de Teste 1	| Verificar se a aplicação consegue coletar dados precisos e atualizados dos atacantes das séries B e C de clubes do Sudeste. |
| Passos 	| - 1. Acessar a funcionalidade de coleta de dados. <br> - 2. Selecionar uma equipe da série B. <br> - 3. Verificar se os dados dos atacantes foram carregados corretamente. |
| Critério de Êxito | - Os dados foram exibidos corretamente |
|  	|  	|

| **Caso de Teste** 	| **CT-02 - Teste de Análise de Desempenho** 	|
|:---:	|:---:	|
| Requisito Associado | RF-006 - A aplicação deve realizar analise de desempenho com precisão |
|	Caso de Teste 2	| Verificar se a aplicação consegue analisar o desempenho dos atacantes com precisão. Para posteriormente divulgar os resultados. |
| Passos 	| - 1. Acessar a funcionalidade de análise de desempenho. <br> - 2. Selecionar um atacante. <br> - 3. Verificar se as estatísticas de desempenho são apresentadas corretamente. |
|Critério de Êxito | - Exibir dados precisos de desempenho corretamente |
|  	|  	|

| **Caso de Teste** 	| **CT-03 - Teste de Identificação de Tendências** 	|
|:---:	|:---:	|
| Requisito Associado | RF-004 - O site deve identificar correntamente as tendências de desempenho | 
|	Caso de Teste 3	| Garantir que a aplicação identifique corretamente as tendências de desempenho dos atacantes. Para selecionar os melhores.  |
| Passos 	| - 1. Acessar a funcionalidade de análise de tendências. <br> - 2. Selecionar um conjunto de atacantes para análise. <br> Verificar se as tendências são identificadas de acordo com os critérios estabelecidos. |
| Critério de Êxito | - Exibir dados sobre tendências de desempenho corretamente |
|  	|  	|

| **Caso de Teste** 	| **CT-04 - Teste de Perfil de Jogador** 	|
|:---:	|:---:	|
| Requisito Associado | RF-001 - Criação e edição de perfil de jogador | 
|	Caso de Teste 4	| Validar se a aplicação permite que os jogadores criem e atualizem seus perfis. Identificando o melhor desempenho entre o jogadores.  |
| Passos 	| - 1. Acessar a funcionalidade de perfil de jogador. <br> - 2. Criar um novo perfil de jogador. <br> - 3. Verificar se as informações do jogador foram salvas corretamente. |
| Critério de Êxito | - O cadastro foi conluído e as alterações foram feitas com sucesso |
|  	|  	|

| **Caso de Teste** 	| **CT-05 - Teste de Recomendação de Melhorias** 	|
|:---:	|:---:	|
|Requisito Associado | RF-008 - Sugerir melhorias relevantes aos perfis de jogadores |
|	Caso de Teste 5	| Confirmar se a aplicação recomenda melhorias para os jogadores com base em seus perfis. Ajundando em desempenho no perfil dos jogadores.  |
| Passos 	| - 1. Acessar a funcionalidade de recomendação de melhorias. <br> - 2. Selecionar um jogador. <br> - 3. Verificar se as recomendações são relevantes para o perfil do jogador. |
| Critério de Êxito | - O site recomendou alteraçoes e melhorias relevantes aos perfis referentes |

| **Caso de Teste** 	| **CT-06 - Visualizar a Página Principal**                                                          	                                                              |
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-01 - A aplicação deve apresentar na página principal informações sobre a descrição do site FutScout 2023.   |
| Objetivo do Teste 	| Identificar se a página inicial está  carregando de forma correta                               |
| Passos 	           | 1. Acessar o Navegador <br> 2. Informar o endereço do Site <br> 3. Visualizar a página principal    |
| Critério de Êxito  | Todos os textos devem ser carregados por completo.                                  |

| **Caso de Teste** 	| **CT-07 - Cadastrar Usuário**                                                                      	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-10 - A aplicação deve permitir que qualquer usuário possa se cadastrar no site.                  |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar no site.                                               |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login<br>4. Clicar em cadastrar<br>5. Informar os dados necessários<br>6. Cadastrar usuário.|
| Critério de Êxito  | Irá aparecer a seguinte mensagem no lado direito do Navegador Web: "Salvar senha."     

| **Caso de Teste** 	| **CT-08 - Cadastrar Jogador**                                                                      	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-10 - A aplicação deve permitir que qualquer usuário possa cadastrar um jogador no site.                  |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar no site.                                               |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login<br>4. Clicar em cadastrar<br>5. Informar os dados necessários<br>6. Cadastrar jogador.|
| Critério de Êxito  | O usuário vai conseguir cadastrar os jogadores após a confirmação na plataforma. 

| **Caso de Teste** 	| **CT-09 - Cadastrar Clube**                                                                      	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-10 - A aplicação deve permitir que qualquer usuário possa se cadastrar um Clube de Futebol no site.                  |
| Objetivo do Teste 	| Confirmar se o usuário consegue se cadastrar no site.                                               |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login<br>4. Clicar em cadastrar<br>5. Informar os dados necessários<br>6. Cadastrar clube.|
| Critério de Êxito  | Irá aparecer uma mensagem como: O cadastro do Clube foi realizado com sucesso.    

| **Caso de Teste** 	| **CT-10 - Editar e Visualizar Dados dos Jogadores**                                                                      	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-10 - A aplicação deve permitir que qualquer usuário possa editar e visualizar os dados dos Jogadores no site.                  |
| Objetivo do Teste 	| Confirmar se o usuário consegue se cadastrar no site.                                               |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login<br>4. Clicar em editar<br>5. Informar os dados necessários<br>6. Editar dados dos jogadores.|
| Critério de Êxito  | O usuário vai conseguir visualizar os seus dados alterados após a confirmação na plataforma.    

| **Caso de Teste** 	| **CT-11 - Editar os Dados Pessoais do Usuário Cadastrado**                                                                      	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-10 - A aplicação deve permitir que qualquer usuário possa editar e visualizar os dados pessoais preenchidos no site.                  |
| Objetivo do Teste 	| Confirmar se o usuário consegue editar e visualizar os dados no site.                                               |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login<br>4. Clicar em editar<br>5. Informar os dados necessários<br>6. Editar dados pessoais.|
| Critério de Êxito  | O usuário vai conseguir visualizar os seus dados alterados após a confirmação na plataforma.    

| **Caso de Teste** 	| **CT-12 - Editar e Visualizar Dados dos Clubes**                                                                      	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-10 - A aplicação deve permitir que qualquer usuário possa editar e visualizar os dados dos Clubes no site.                  |
| Objetivo do Teste 	| Confirmar se o usuário consegue se cadastrar no site.                                               |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login<br>4. Clicar em editar<br>5. Informar os dados necessários<br>6. Editar e visualizar dados|
| Critério de Êxito  | Todas as informações dos clubes cadastrados vão estar expostas no site.   

| **Caso de Teste** 	| **CT-13 - Verificar Lista de Atacantes Cadastrados na Aplicação**                                                                      	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-10 - A aplicação deve permitir que qualquer usuário possa editar e visualizar os dados dos Atacantes no site.                  |
| Objetivo do Teste 	| Confirmar se o usuário consegue ver as seguintes informações no site: Nome, Idade, Clube, Partidas, Gols e Assistências nos anos de 2021, 2022 e 2023.                                            |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login<br>4. Clicar em ver lista<br>5. Informar os dados necessários<br>6. Verificar lista.|
| Critério de Êxito  | Todas as informações dos atletas cadastrados vão estar expostas no site.


| **Caso de Teste** 	| **CT-14 - Deletar Usuário Cadastrados na Aplicação**                                                                      	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-10 - A aplicação deve permitir que o usuário consiga deletar o seu cadastro no site.                |
| Objetivo do Teste 	| Confirmar se o usuário consegue deletar a sua conta no site.                                           |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login<br>4. Clicar em deletar<br>5. Informar os dados necessários<br>6. Deletar dados|
| Critério de Êxito  | A confirmação para exclusão deve ser exposta para o usuário.

| **Caso de Teste** 	| **CT-15 - Deletar Clubes Cadastrados na Aplicação**                                                                      	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-10 - A aplicação deve permitir que o usuário consiga deletar o cadastro de um Clube no site.                |
| Objetivo do Teste 	| Confirmar se o usuário consegue deletar a sua conta no site.                                           |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login<br>4. Clicar em deletar<br>5. Informar os dados necessários<br>6. Deletar dados|
| Critério de Êxito  | A confirmação para exclusão deve ser exposta para o usuário.

| **Caso de Teste** 	| **CT-16 - Deletar Atacantes Cadastrados na Aplicação**                                                                      	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-10 - A aplicação deve permitir que o usuário consiga deletar o cadastro do Atacante no site.                |
| Objetivo do Teste 	| Confirmar se o usuário consegue deletar a sua conta no site.                                           |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login<br>4. Clicar em deletar<br>5. Informar os dados necessários<br>6. Deletar dados|
| Critério de Êxito  | A confirmação para exclusão deve ser exposta para o usuário.

| **Caso de Teste** 	| **CT-17 - Deletar e Editar as Estatísticas dos Atacantes Cadastrados na Aplicação**                                                       
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-10 - O usuário consegue visualizar as estatísticas do Atacante cadastrado.               |
| Objetivo do Teste 	| Confirmar se o usuário consegue deletar a sua conta no site.                                           |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login<br>4. Clicar em editar e deletar<br>5. Informar os dados necessários<br>6. Deletar ou editar dados|
| Critério de Êxito  | A confirmação para exclusão e editar deve ser exposta para o usuário.

| **Caso de Teste** 	| **CT-18 - Verificar as Políticas de Privacidade na Aplicação**                                                                      	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-10 - O usuário consegue visualizar as informações de Privacidade na Aplicação.               |
| Objetivo do Teste 	| Confirmar se o usuário consegue visualizar as informações sobre a segurança de dados pessoais no site.                                           |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login<br>4. Clicar em ver políticas<br>5. Informar os dados necessários<br>|
| Critério de Êxito  | Confirmação para verificar as informações das políticas do site exposta para o usuário.

**Critérios de Aceitação**
Todos os casos de teste devem ser executados e passar com sucesso. <br> A aplicação deve fornecer resultados precisos e relevantes. <br> O desempenho da aplicação deve ser satisfatório, mesmo sob carga.

**Considerações Finais**
Este plano de teste deve ser executado de forma abrangente e sistemática para garantir a qualidade e a eficácia da aplicação no contexto de análise de desempenho de atacantes das séries B e C de clubes do Sudeste, bem como na promoção dos próprios jogadores.
