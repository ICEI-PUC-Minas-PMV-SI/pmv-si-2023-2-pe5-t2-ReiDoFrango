### ESTRUTURAÇÃO DA INFRAESTRUTURA DE REDE DA EMPRESA AGROPECUÁRIA REI DOS FRANGOS

## 1- INTRODUÇÃO

O artigo tem como objetivo desenvolver e documentar a infraestrutura de redes para a empresa agropecuária Rei do Frango, uma renomada empresa na produção e pesquisa de frangos de corte. A empresa possui quatro locais principais, incluindo a sede em Belo Horizonte e três fazendas localizadas em Viçosa, Uberaba e Uberlândia.
A infraestrutura de redes proposta visa atender às necessidades específicas da empresa em termos de comunicação e conectividade entre esses quatro locais geograficamente dispersos.

## 2- RECURSOS DE REDE

Neste capítulo é apresentado os recursos de rede seguindo boas práticas de documentação, explorando todas as ferramentas de maneira minuciosa.

### 2.1- Equipamentos necessários

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/tabela1.JPG">

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/tabela2.JPG">

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/tabela3.JPG">

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/tabela4.JPG">

Ao analisar as tabelas é possível notar que Belo Horizonte (tabela 01), como a sede, possui requisitos mais diversificados de equipamentos para atender a diversos setores.
As fazendas Viçosa (tabela 02), Uberaba (tabela 03) e Uberlândia (tabela 04) têm necessidades mais focadas em equipamentos IoT para Aviário e Estoque, refletindo a natureza das operações agropecuárias.
A presença de câmeras de segurança é consistente em todas as localidades, indicando um compromisso com a segurança e o monitoramento em todas as instalações.
Em resumo, os contrastes nas necessidades de equipamentos refletem as diferentes funções e operações desempenhadas em cada localidade, com Belo Horizonte atuando como a central de operações e as fazendas tendo requisitos mais específicos relacionados à produção e pesquisa agropecuária.
### 2.2 - Orçamento dos equipamentos

O orçamento foi meticulosamente elaborado por meio de uma pesquisa exaustiva nas lojas de tecnologia mais confiáveis e renomadas do mercado. Durante esse processo, buscamos incessantemente pelo melhor custo-benefício, visando garantir que os recursos financeiros da empresa fossem alocados de maneira eficiente e que cada compra refletisse a qualidade e a adequação às necessidades específicas de cada local, seja na matriz em Belo Horizonte ou nas fazendas em Viçosa, Uberaba e Uberlândia. Essa abordagem rigorosa assegura que os investimentos em infraestrutura de TI estejam alinhados com os objetivos da empresa Rei do Frango, garantindo eficiência operacional e suporte às operações em todos os locais. Os dados foram organizados na tabela abaixo.

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/orcamento.JPG">

Ao analisar a figura 01 de orçamento de materiais revela algumas tendências e diferenças notáveis nas necessidades de infraestrutura de TI em cada local. Esses contrastes refletem a complexidade das operações da empresa Rei do Frango em locais distintos, com a matriz atuando como o centro de operações principal e as fazendas atendendo a necessidades específicas relacionadas à produção agropecuária.
	Em relação aos equipamentos específicos, observa-se que a matriz possui requisitos mais substanciais em alguns aspectos. Por exemplo, a matriz adquiriu um número significativamente maior de estações Dell (43) em comparação com cada fazenda (10). Isso se deve ao fato de a matriz ter uma equipe de trabalho maior, além de atuar como o centro de operações principal.
	Em termos de conectividade de rede, todos os locais adquiriram roteadores CISCO, switches Dell 24p e patch cords CAT6 em quantidades semelhantes, indicando a importância da conectividade confiável em todas as instalações.
No entanto, a quantidade de cabos UTP CAT6 variou consideravelmente, com a matriz adquirindo mais do que as fazendas. Isso reflete diferenças nas necessidades de cabeamento de rede em cada local.

### 2.3 - Largura de banda

A tabela abaixo apresenta uma análise detalhada da necessidade de link de internet para as várias ferramentas de rede nas diferentes localidades da empresa, incluindo a matriz e as fazendas. 

 <img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/banda.JPG">

 Através da análise da figura 02 dos requisitos de link de internet podemos perceber uma distribuição variada das necessidades de largura de banda. A matriz apresenta demandas mais substanciais em várias aplicações, com destaque para o acesso à web, onde requer 5.000 kbps (5 Mbps), e e-mail, com 2.000 kbps (2 Mbps). As fazendas 1 e 2 têm requisitos menores em comparação com a matriz, enquanto a fazenda 3 apresenta os requisitos mais baixos em todas as aplicações.
Essa análise enfatiza a importância de dimensionar adequadamente a capacidade de internet em cada localidade para garantir que todas as aplicações funcionem de maneira eficiente e confiável. Além disso, demonstra a relevância da matriz como o centro das operações com requisitos mais elevados em várias aplicações.

## 3- PROTÓTIPO DA REDE

A imagem abaixo (figura 3) representa o protótipo da rede desenvolvido no Simulador da Cisco Packet Trace, uma representação visual das configurações e interconexões dos dispositivos de rede planejados para a infraestrutura da empresa Rei do Frango. Essa visualização oferece uma visão detalhada e prática da rede, facilitando a análise, o teste e a otimização das configurações antes da implementação real.

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura3.png">

Interpretando a figura 3 podemos observar que a topologia em estrela foi adotada, isso ocorre devido ao fato de ser uma escolha altamente adequada para o projeto de redes da empresa Rei do Frango por inúmeras razões cruciais. Primeiramente, essa topologia permite a centralização do controle da rede em um ponto central, tornando a administração e o monitoramento da rede muito mais eficiente. Isso é particularmente valioso para uma empresa com várias localidades, como a Rei do Frango, pois simplifica a gestão da rede.
	
Além disso, essa topologia é notável por sua facilidade de manutenção. Problemas em dispositivos ou conexões não afetam o funcionamento dos outros dispositivos da rede, facilitando a identificação e isolamento de problemas, o que reduz o tempo de inatividade.
A escalabilidade é outra vantagem importante, pois a topologia em estrela permite a expansão simples da rede com a adição de novos dispositivos ou localidades, adaptando-se facilmente ao crescimento da empresa.
No contexto das múltiplas fazendas geograficamente dispersas da empresa Rei do Frango, a topologia em estrela se destaca como uma escolha eficaz para gerenciar e conectar todas essas localidades à sede central. Isso promove a eficiência operacional, a segurança e a escalabilidade da rede, atendendo às necessidades específicas da empresa no setor agropecuário.

## 4- DISTRIBUIÇÃO DOS IPs
	
 A figura 4 abaixo descreve a alocação de endereços IP para dispositivos em diferentes localizações da rede da empresa Rei do Frango. Cada dispositivo possui um tipo específico e uma função designada, juntamente com seu endereço IP exclusivo e localização correspondente. Essa organização permite um controle preciso sobre a rede, identificando claramente a função de cada dispositivo e sua localização geográfica. Isso é essencial para a administração e o gerenciamento eficazes da rede, garantindo que todos os dispositivos estejam configurados corretamente e cumpram suas funções designadas em suas respectivas filiais ou na matriz da empresa.

<img src="https://github.com/ICEI-PUC-Minas-PMV-SI/pmv-si-2023-2-pe5-t2-gado_de_ouro/blob/main/img/figura4.jpg">

A distribuição de IPs (figura 4) segue uma organização estruturada e hierárquica, levando em consideração as funções específicas dos dispositivos e suas localizações geográficas dentro da rede da empresa Rei do Frango.
Na sede central da empresa, conhecida como "Matriz", o Roteador_Matriz (192.168.0.1) atua como ponto de conexão à internet. O Servidor_Matriz (192.168.0.2) desempenha funções de servidor e DHCP, enquanto a Impressora (Impressao_Matriz) utiliza o endereço IP 192.168.0.4 para tarefas de impressão. Além disso, o Ponto de Acesso Wi-Fi (Ponto_Acesso_Matriz) possui endereços IP na faixa 192.168.0.N para oferecer conectividade sem fio na matriz.
Nas filiais, como a "Filial 01", o Roteador_Filial01 (192.168.1.1) faz a conexão à internet, e o Servidor_Filial01 (192.168.1.2) age como servidor e fornece serviços DHCP. A Impressora (Inpressao_Filial01) usa o IP (192.168.1.4) para impressão, e o Ponto de Acesso Wi-Fi (Ponto_Acesso_Filial01) disponibiliza conectividade sem fio com endereços IP na faixa (192.168.1.N). A Estacao01_Matriz possui o IP (192.168.0.6) e é designado como estação de trabalho na Matriz.

Na "Filial 02", o Roteador_Filial02 (192.168.2.1) atua como ponto de acesso à internet, e o Servidor_Filial02 (192.168.2.2) desempenha funções de servidor e DHCP. A Impressora (Impressao_Filial02) utiliza o IP (192.168.2.4) para impressão, e o Ponto de Acesso Wi-Fi (Ponto_Acesso_Filial02) (oferece conectividade sem fio com endereços IP na faixa (192.168.2.N). Além disso, o SensorTemp tem o IP (192.168.2.N) e é destinado à monitorização de temperatura no aviário da Filial 02.
Na "Filial 03", o Roteador_Filial03 (192.168.3.1) é o ponto de acesso à internet, e o Servidor_Filial03 (192.168.3.2) atua como servidor e fornece serviços DHCP. A Impressora (Impressao_Filial03) utiliza o IP (192.168.3.4) para tarefas de impressão, e o Ponto de Acesso Wi-Fi (Ponto_Acesso_Filial03) disponibiliza conectividade sem fio com endereços IP na faixa (192.168.3.N). A Cam_sec_filial03 (Câmera de Segurança) usa o IP (192.168.3.N) para fins de segurança na Filial 03.
Essa distribuição meticulosa de IPs é essencial para garantir que cada dispositivo tenha um endereço único e cumpra sua função de maneira eficaz em sua localização específica. Isso facilita a identificação, configuração e gestão de dispositivos em toda a infraestrutura de rede, contribuindo para um ambiente de trabalho organizado e eficiente na empresa Rei do Frango.
