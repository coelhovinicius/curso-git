/* Repositorio GIT
 
    > Criando o arquivo GITIGNORE - Para criarmos o arquivo ".gitignore", devemos:
        - Criar um (novo) documento de texto, com qualquer nome;
        - Renomear o arquivo pelo prompt: <Shift> + <Botao direito do mouse> - selecionar a opcao "Abrir janela de 
         comando aqui (ou "Power Shell");
        - Na linha de prompt, digitar: ren nomeDoArquivo.txt .gitignore.

    O arquivo GITIGNORE devera conter instrucoes de quais arquivos deverao ser ignoradas pelo repositorio Git (arquivos
que nao precisam de controle de versao).
    Para sabermos quais arquivos devemos indicar para o repositorio Git ignorar, devemos verificar no proprio site do
GitHub, buscando por "gitignore visual studio 2019" no Google e acessando ao link correspondente a pagina do GitHub.
Normalmente, e a seguinte: https://github.com/github/gitignore/blob/master/VisualStudio.gitignore. Basta copiar a lista
que esta disponibilizada ao arquivo .gitignore, abrindo-o como bloco de notas, por exemplo;

    > Inicianto um Repositorio Git na pasta do projeto desejada:    
        - Abrir o Git Bash clicando com o botao direito do mouse na pasta do projeto e selecionando "Git Bash Here";
        - Digitar, no prompt que foi aberto, o comando "git init";
        - Uma pasta oculta ".git" e criada dentro da pasta do projeto. Ela e o repositorio que controlara as versoes.
          Esta pasta nao deve ser alterada. 

    > Identificacao para o Git - No Git Bash:
        - Comando: git config --global user.name "Seu Nome";
        - Comando: git config --global user.email "Seu Email"; // O mesmo do GitHub, de preferencia
        - A partir disso, estara identificado quem fara as alteracoes no repositorio Git.

    > Salvando uma Versao do projeto - A acao de se salvar uma Versao do projeto, damos o nome de COMMIT:
        - A cada vez que alteramos um projeto com sucesso, devemos fazer um Commit;
        - GIT STATUS: git status - verifica como esta o repositorio Git do projeto;
        - Os arquivos indicados em vermelho ainda nao foram rastreados pelo Git;
        - GIT ADD . : git add . - coloca os arquivos modificados na area de "Stage". Essa, por sua vez, e a area onde
          vao os arquivos que estao protos para participarem do Commit que sera rodado;
        - GIT COMMIT -M "DESCRICAO": git commit -m "Descricao do commit" - comentario sobre o que foi alterado
        - GIT LOG: git log - informa o log com todas as alteracoes efetuadas
        - GIT LOG --ONELINE: git log --oneline - informa os logs de forma sucinta

*/

using System;

namespace Aula98_RepositorioGit {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Repositorio Git:");
            Console.WriteLine("Converte o projeto para um repositorio Git");
            Console.WriteLine("Outra alteracao");
            Console.WriteLine("Teste");

            Console.WriteLine();

        }
    }
}
