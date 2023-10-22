# Plano de Usabilidade

O teste de usabilidade será realizado por um questionário de UX através da plataforma Google Forms, sistema este popularmente conhecido, o que facilita na participação de uma vasta pluralidade de usuários.

**Imagem do Google Forms criado:**

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time2-futebol/assets/126628545/9fba54e2-381e-48f4-8a34-8f3bb6302f39)

**Imagem do Google Forms quando o usuário responder as respostas:**

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time2-futebol/assets/126628545/c1ab8146-59bc-4efb-95e0-96ececa1becc)


Os usuários testados vão responder às seguintes perguntas demonstradas abaixo:

    1. Gostaria de utilizar esse sistema com muito mais frequência.
    2. Achei o sistema muito fácil de usar.
    3. Achei o sistema desnecessariamente complexo.
    4. Pensei que fosse necessário o suporte de algum especialista técnico para usar esse sistema.
    5. Todas as funções do sistema estão muito bem integradas na plataforma.
    6. Achei o sistema muito inconsistente na sua navegabilidade.
    7. Acredito que qualquer pessoa consegue aprender a usar o sistema de forma ágil, sem problemas de aprendizado.
    8. Achei o sistema difícil de usar.
    9. Me senti confiante ao acessar o sistema.
    10. Eu preciso aprender muitas regras de navegabilidade para continuar usando este sistema.
    11. Eu me senti acolhido e confortável com o sistema.
    12. É fácil e acessível encontrar as informações que eu precisava.
    13. Eu achei positiva a experiência de usar a interface proposta pelo sistema.
    14. A experiência do usuário na interface do sistema é agradável.
    15. As informações e a organização na tela do sistema é de fácil entendimento.

Cada pergunta acima exposta no questionário contém cinco opções de respostas para os participantes:

**1)** Discordo Totalmente, **2**) Discordo, **3)** Neutro, **4**) Concordo e **5)** Concordo totalmente.

# Caso de Teste

Conforme as informações adquiridas, a equipe de Desenvolvimento da aplicação realizará os possíveis ajustes e melhorias na plataforma:
 
| **Caso de Teste** 	| **CT-12 - Responsividade**                                                                           	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RNF-002	A aplicação deverá ser responsiva permitindo a visualização em diferentes telas de forma adequada   |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar a aplicação em outros aparelhos, para verificar se é responsiva.                                     |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Testar a aplicação em outros aparelhos, como celular, ipad e computador                      |
| Critério de Êxito  | A aplicação é responsiva com todos os meios de acesso, como celular, ipad e computador.                                  | 

| **Caso de Teste** 	| **CT-13 - Navegadores**                                                                           	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RNF-04- A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge).   |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar a aplicação interativa em outros navegadores.                                     |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Testar a aplicação em outros navegadores                      |
| Critério de Êxito  | A aplicação é compatível com os principais navegadores do mercado.                                  | 

| **Caso de Teste** 	| **CT-14 - Usuários**                                                                           	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RNF-005	A aplicação não permite o recebimento de cadastros de usuários com dados necessários em branco.   |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar sem preencher dados, deixando em branco.                                     |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. ir em registrar <br> 4. Tentar cadastrar um usuário sem dados. <br> 5. salvar dados|
| Critério de Êxito  | Não irá permitir o cadastro do usuário pois precisa preencher os dados.                                  | 


| **Caso de Teste** 	| **CT-15 - Erro de cadastro e login**                                                                           	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RNF-006	A aplicação deverá informar o erro de cadastro e login para o usuário caso os dados inseridos não estejam no banco de dados.   |
| Objetivo do Teste 	| Verificar se quando for fazer o cadastro ou login irá retornar um erro e/ou falha.                                     |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Realizar o cadastro equivocados. <br> 4. Verificar se mostra a falha|
| Critério de Êxito  | Irá retornar uma falha no registro do usuário.                                  | 
