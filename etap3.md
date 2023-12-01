## 7- MONITORAMENTO DOS AMBIENTES DE REDE

Para monitorar os ambientes, será utilizada a ferramenta Zabbix. O Zabbix é uma ferramenta de software versátil que monitora uma grande variedade de parâmetros de rede e a saúde de servidores, máquinas virtuais, aplicações, bancos de dados, websites, entre outros. Ele oferece notificações flexíveis via e-mail para alertas de eventos, possibilitando uma resposta rápida a problemas que afetam os servidores.
Uma característica do Zabbix é sua capacidade de proporcionar recursos robustos para a criação de relatórios e a visualização de dados, com base nas informações armazenadas. Essa funcionalidade torna o Zabbix uma escolha ideal para o gerenciamento de capacidade, permitindo que os administradores monitorem e tomem decisões com base nos dados coletados.
O Zabbix usa principalmente o protocolo SNMP (Simple Network Management Protocol) para monitorar dispositivos de rede, mas também suporta protocolos como ICMP (Internet Control Message Protocol) para monitoramento de conectividade e agentes Zabbix para monitorar sistemas e serviços. Ele opera em uma arquitetura de gerente e agente, no qual o agente coleta os dados localmente e o gerente consolida os dados recebidos gerando relatórios e gráficos. O protocolo SNMP é amplamente utilizado para coletar informações de dispositivos de rede, como roteadores, switches e impressoras.
As seguintes etapas foram seguidas:
1. Configuração do gerente. Foi realizada a importação do appliance do zabbix para o Virtual Box conforme demonstrado na figura 23. O appliance utiliza o sistema operacional Linux, distribuição CentOs 8 juntamente com o Apache, PHP e Mysql para implementar a ferramenta de gerência. Após importar, configurou-se a placa de rede da máquina para operar em modo bridge, para poder conectar-se a outras máquinas na rede local conforme figura 24:

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura23.JPG">
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura24.JPG">

2. Execução do appliance representada na figura 24. Após importar o appliance para o virtual box, foi executada a máquina virtual com o appliance e observado o ip obtido.
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura25.JPG">
3. Instalação do agente no servidor local. Foi realizada a instalação do serviço de SNMP no servidor local (Servidor Matriz) para responder a consultas SNMP. Através do Server Manager no windows server. O serviço foi configurado com string de comunidade para segurança conforme demonstrado a seguir na figura 25:
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura26.JPG">
4. Acesso via navegador para o ip atribuído ao Zabbix (figura 26), neste exemplo 192.168.0.8. O usuário é Admin e a senha é zabbix.
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura27.JPG">
5. Adição de hosts. Na tela de configuração, após a tela de login, foi adicionado um host para que o Zabbix Server recolha seus dados. O Host foi configurado de modo a usar interface SNMP e usar a porta 161 para recebimento dos protocolos snmp conforme demonstrado na figura 27.
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura28.JPG">
6. Conforme figura 28, observa-se a visualização dos hosts. Após adicionar o host, as seguintes telas aparecerão com as cores em verde indicando ausência de erros.
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura29.JPG">
7. Acesso aos gráficos. Clicando em Graphs pode-se acessar os diversos gráficos disponíveis no zabbix com os dados coletados no agente no servidor local (figuras 29, 30 e 31):
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura30.JPG">
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura31.JPG">
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura32.JPG">
CONCLUSÃO:
Foi apresentada uma visão da configuração do Zabbix em um servidor local, demonstrando a importância dessa ferramenta de monitoramento na gestão de sistemas e redes. Através de imagens, todo o processo de implantação e configuração do Zabbix pôde ser acompanhado.

## Configuração de Servidor na Nuvem AWS para Monitoramento com Zabbix

### INTRODUÇÃO
O objetivo da documentação é fornecer um passo a passo da configuração do servidor na plataforma de nuvem AWS (Amazon Web Services) e a integração desse servidor na rede do Zabbix, uma ferramenta de monitoramento e gerenciamento de sistemas. O Zabbix permite monitorar o desempenho e a disponibilidade de serviços, aplicativos e recursos em tempo real, tornando-o uma escolha ideal para a manutenção de servidores na nuvem.
### PRÉ-REQUISITOS PARA CONFIGURAÇÃO:
 Uma conta ativa na AWS.
 Acesso às credenciais da conta AWS.
 Conhecimento básico do Zabbix e sua infraestrutura.
 Uma instância de servidor Zabbix já configurada e em funcionamento.
### PASSOS PARA CONFIGURAÇÃO:
1. Acesso à instancia EC2 (figura 32). Foi feito o acesso á instancia EC2 que foi configurada na etapa 6, através do acesso remoto (RDP):
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura33.JPG">
2. Configuração Segurança de Grupo: No passo de configuração da instância EC2, foram definidas as regras de segurança do grupo para permitir a comunicação com o servidor Zabbix. Foi aberta a porta necessária para o Zabbix, geralmente a 10050 TCP, e restringindo o acesso a partir do endereço IP do servidor Zabbix conforme demonstrado em figura 33.
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura34.JPG">
3. Instalação do Agente Zabbix na Instância EC2 (figura 34). Foi feita a instalação do serviço de SNMP na instância EC2, que executa o Windows server 2016. Após a instalação o serviço é configurado para permitir a troca de mensagens SNMP.
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura35.JPG">
4. Adição e configuração do host no Zabbix: No servidor Zabbix, adicionou-se o novo host representando a instância EC2 conforme figura 35. O Host name configurado (AWS Reis dos Frangos):
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura36.JPG">
5. Acesso aos gráficos. Clicando em graphs, é disponibilizado diversos gráficos sobre os dados coletados da instância EC2 como as seguintes figuras 36 e 37:
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura37.JPG">
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura38.JPG">
6. Foi criado um mapa de rede representando as conexões entre o zabbix server, o servidor local e a instância na nuvem conforme figura 38:
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura39.JPG">

## CONCLUSÃO
Após a configuração com sucesso um servidor na nuvem AWS e a integração à rede do Zabbix para monitoramento contínuo. Conclui-se que o processo permitirá que se mantenha um controle detalhado das métricas de desempenho da instância EC2 (servidor virtual na nuvem) e tome medidas proativas para garantir a disponibilidade e o desempenho ideal dos recursos na nuvem.
