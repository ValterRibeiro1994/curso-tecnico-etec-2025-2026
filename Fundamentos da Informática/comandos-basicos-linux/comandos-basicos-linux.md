# Comandos universais do Linux
- **whoami:** usado para indentificar o usuario do sistema (tambem funciona no windows)
    - Essa configuração pode ser alterada nas configurações do sistema

- **~:** Raiz do usuário normal
    - Usuario Normal não tem previlegios de adm
- **#:** Raiz do usuário root
    -  Usuario Root tem instruções previlegiadas tendo mais controle e responsabilidade sobre a maquina

- **clear:** Limpa o terminal de saida
- **ls:** Ele lista todos os arquivos do diretorio atual
    - Ele possui parâmetros para visualizar autorizações **-l**, visualizar arquivos ocultos **-a**

- **cd:** Altera o diretorio de trabalho, sua vantagem que se pode especificar o caminho de qualquer pasta e o acesso será direto, ou seja sem cliques de abre ali, entra la e etc.
    - **cd** tem alguns atalhos uteis ele sozinho muda o diretorio de trabalho para o diretorio ($HOME)
    - **cd -** muda para o diretorio anterior
    -> se voce digitou cd pasta1/pasta2/pasta3 estando na area de trabalho ele volta para area de trabalho ao inves de ir para pasta 2 que seria o diretorio pai
    - **cd ..** altera o diretorio de trabalho para a pasta pai (Uma pasta acima)
    - **cd ~** Ele muda para o diretorio inicial de usuario
    - **cd ~<outro-usuario>** Permite ir para a raiz de outro usuario

- **mkdir:** Cria um diretorio 
    - Para dar nomes com espaço é necessario deixar o nome entre aspas, Isso porque nomes separados sem aspas cria varias pastas diversas
    por exemplo: mkdir uma pasta -> cria duas pastas (uma, pasta) e se não for a intenção faça assim mkdir 'uma pasta', o resultado será uma pasta(uma pasta)

- **rmdir:** Remove diretorios Vazio (apenas diretorio)
- **rm:** Remove arquivos e para diretorios com arquivos use o **-r** (Remove os elementos internos recursivamente)
- **man:**



# Usando o APT para remover e instalar pacotes
 - **sudo:** É uma forma de dizer faça com previlegios te dou as permissões necessarios (a grande maioria ou todos os pacotes linux precisa), ele é usado para tarefas administrativas
 - **apt:** É o gerenciador de pacotes para sistemas Linux
 - **update:** É um parametro utilizado para atualizar algum software, ou o proprio sistema operacional
 - **upgrade:** É um parametro utilizado para atualizar todos os pacotes do sitema
 - **full-upgrade**: Realiza uma atualização completa do sistema, o que pode incluir a instalação de novos pacotes para gerenciar dependências ou a remoção de pacotes obsoletos, se necessário.
 - **purge <pacote>:** Remove um pacote e todos os seus arquivos de configuração do sistema
 - **clean:** Limpa o cache local de arquivos de pacotes (.deb) baixados, liberando espaço em disco.
 - **check:** É usado para verificar se há dependências quebradas (incompletas ou faltantes) no sistema de pacotes.
 - **download:** <pacote>: Baixa o arquivo .deb de um pacote para o diretório atual, sem instalá-lo.
 - **search <termo>:** Procura por pacotes cujos nomes ou descrições correspondam ao termo de pesquisa especificado.
 - **show <pacote>:** Exibe informações detalhadas sobre um pacote, como sua versão, tamanho, dependências e descrição.
 - **autoremove:** Remove automaticamente pacotes que foram instalados como dependências, mas que não são mais necessários por nenhum software instalado
 - **dist-upgrade:** O mesmo que full-upgrade
 -**apt-cache:** Exibe as dependecias do pacote 
 - **install:** Instala um pacote
 - **uninstall:** Desinstala um pacote
 - **list:** lista pacotes disponiveis nos repositorios
    - **--installed:** verifica todos os pacotes instalados
    - **--upgradable:** verifica os pacotes que podem ser atualizados
    - **<nome-do-pacote>:** Verifica informações detalhadas sobre um pacote especifico
    - **grep:** Se pode usar o grep buscar todos os pacotes que tem uma certa palavra
    - **search:** Localiza o pacote pelo nome

- **Exemplos:**
    sudo apt install sl (sl é o pacote do trem :)
    sudo apt uninstall sl (apenas se quiser remover :)
    sudo apt update (atualiza os pacotes do sistema)
    sudo apt upgrade (atualiza os pacotes do sistema)
    sudo apt list --installed (verifica os pacotes instalados)
    sudo apt list --upgradable (Ele não atualiza diretamente)
    apt list sl (Vamos ver a informação do trem)
    apt list | grep te (Ele vai filtrar todos os pacotes com o termo 'te')


# Outros comandos essenciais 
 - **free:** Necessario para visualizar mmemoria total( em uso e disponivel), assim como visualizar a memoria do cachê e swap
    - **free -h** deixa a saida mais legivel
    - **free -m** para visualizar as informações megabytes

- **man:** Ele abre o manual (documentação interna de qualquer pacote instalado, fundamental para buscar informações)

- **!!:** Esse comando retorna o comando anterior
- **dpkg -i:** Instalar arquivos de instalação 