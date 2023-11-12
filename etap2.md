## 5 - VIRTUALIZAÇÃO LOCAL

Realizou-se a virtualização do servidor para simular serviços on-premises, sendo o principal objetivo criar um servidor com função de controlador de domínio, além de possuir funções de DHCP e atribuição de DNS e por fim adicionar uma estação ao domínio seguindo as políticas estabelecidas. O serviço de virtualização utilizado foi o Virtual Box. 
Primeiramente, foi instalada uma máquina virtual com o Sistema Operacional Windows Server 2012. Após isso, renomeamos a máquina para o nome do servidor "Servidor_Matriz". Modificamos o IP na seção da interface de rede para ser condizente com a tabela de IPs. Atribuímos a esse servidor as funções de DNS e AD DS, transformando-o em Domain Controller (DC). Em seguida, um nome de domínio raiz foi estabelecido como "ReiDoFrango.local". Adicionalmente, adicionamos a função de DHCP ao servidor para atribuição automática de IPs, conforme ilustrado nas Figuras 5, 6, 7 e 8 abaixo: 

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura5.JPG"> 

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura6.JPG"> 

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura7.JPG"> 

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura8.JPG"> 

1.	Após isso criou-se as unidades organizacionais Minas conforme mostra a figura 9, com as UOs dentro representando a sede Belo Horizonte e as fazendas Viçosa, Brumadinho e Uberaba:

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura9.JPG"> 

2.	Foi criada em belo horizonte a política de usuários pgbh que restringe ações como acessar o painel de controle, desinstalar e deletar programas entre outros demonstrada na figura abaixo:

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura10.JPG">

Um usuário foi criado na UO de Belo Horizonte. Por fim, adicionou-se uma estação ao domínio e forçamos a aplicação das políticas de usuário estabelecidas. Conectamos à aplicação web do Rei dos Frangos, conforme pode-se observar nas Figuras 11, 12, 13 e 14:

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura11.JPG">

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura12.JPG">

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura13.JPG">

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura14.JPG">

## 6 - IMPLANTAÇÃO NA NUVEM

Após realizar a virtualização local, foi realizada a implantação dos servidores na nuvem através dos serviços da AWS (Amazon Web Services). A implantação foi realizada por meio de uma VPC (Virtual Private Network) para criar uma rede privada na nuvem. A seguinte estrutura (figura 15) foi utilizada como base:

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura15.JPG">

Os seguintes passos foram seguidos: 
1. Foi criada uma VPC com um bloco CIDR conforme figura 16:

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura16.JPG">

2. Criaram-se as subredes (figura 17). Dentro dessa VPC há duas zonas de disponibilidade com duas subredes cada, sendo uma pública e outra privada. Cada subrede possui sua tabela de rotas para direcionar o tráfego de rede. A subrede pública direciona o tráfego roteável pela internet para o gateway da internet que executa a conversão de endereços de rede para instâncias com endereços ipv4 públicos. Já a subrede privada aponta seu tráfego vinculado à internet para o gateway NAT, que reside em uma subrede pública e faz a conversão de endereços ips privados para um ip público para acesso à internet. No nosso caso, não foi utilizado um gateway NAT.

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura17.JPG">

3.Após isso, criou-se um grupo de segurança, que funciona como um firewall para as instâncias, controlando o tráfego de entrada e de saída. O grupo de segurança possui duas regras de entrada: HTTP e acesso remoto (RDP) como demonstrado na Figura 18.

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura18.JPG">

4. O servidor web foi implementado através de uma instância EC2 da Amazon. Atribuiu-se um nome à instância e foi escolhido o tipo de instancia e seu par chave-valor associado. A instancia escolhida foi o Windows Server 2016. Foram realizadas as configurações de rede, colocando a instancia na subrede pública da nossa VPC e com ip público automático. A instância seguirá as políticas de segurança estabelecidas, como acesso por http e remoto conforme figura 19:

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura19.JPG">

5. Foi feita a execução remota da instancia inserindo as credenciais de acesso como demonstrado na figura 20.

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura20.JPG">

6.  A instancia foi configurada para rodar o servidor web conforme figura 21:
   
<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura20.JPG">

8. Acesso ao site da aplicação Rei dos Frangos através do ip público da instância (figura 22):

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura22.JPG">




