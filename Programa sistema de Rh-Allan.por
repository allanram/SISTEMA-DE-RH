programa
{
	
	inclua biblioteca Tipos --> Tip
	inclua biblioteca ServicosWeb --> S
	inclua biblioteca Texto -->Te
        inclua biblioteca Matematica --> M
        inclua biblioteca Arquivos --> arq
	inteiro operacao_cliente
	funcao inicio()
	{
		limpa()
		escreva("Olá,seja bem vindo(a) ao sistema de operaçoes do RH.\n")
		escreva("Para escolher a operação selecione:\n")
		escreva("(1)_Menu de operaçoes.\n")
		escreva("(2)_Cadastro.\n")
		escreva("\nDigite um numero:\n")
		leia(operacao_cliente)

		se(operacao_cliente == 1)
		{
			 menu_operacoes()
		}
		senao se(operacao_cliente == 2)
		{
			cadastro_cliente() 
		}
		senao
		{
			escreva("Informe uma opção valida.\n")
			inicio()
		}
	}
	funcao menu_operacoes()
	{
		
		limpa()
		escreva("\n========MENU DE OPERACOES===========\n")
		escreva("1-Simulador de Descontos do Inss\n")
		escreva("2-Calculo das ferias\n")
		escreva("3-Desconto do imposto de renda\n")
		escreva("4-Simulador de adicional noturno\n")
		escreva("5-Simulador de horas extras\n")
		escreva("6-Simulador adicional por Periculosidade\n")
		escreva("7-Simulador contribuição FGTS\n")
		escreva("8-Simulador multa do FGTS.\n")
		escreva("9-Simulador do Pis.\n")
		escreva("10-Simulador seguro desemprego.\n")
		escreva("11-Simulador vale transporte.\n")
		escreva("12-Simulação Completa.\n")
		escreveLinha()
		escreva("\n")
		escreva("Informe o numero da operacao escolhida: ")
		leia(operacao_cliente)

		escolha(operacao_cliente)
		{
			caso 1: simuladorInss()
			pare
			caso 2: simulador_calculo_ferias()
			pare
			caso 3: simulador_imposto_de_renda()
			pare
			caso 4: simulador_adicional_noturno()
			pare
			caso 5: simulador_horas_extras()
			pare
			caso 6: simulador_adicional_periculosidade()
			pare
			caso 7: simulador_contribuicao_fgts()
			pare
			caso 8: simulador_multa_fgts()
			pare
			caso 9: simulador_pis()
			pare
			caso 10: simulador_seguro_desemprego()
			pare
			caso 11: simulador_vale_transporte()
			pare
			caso 12: simulacao_completa()
			
			
		}
	}
	funcao simuladorInss()
	{
		real descontoInss=0.0
		real salario_bruto
		escreva("Informe o valor do salario:\n")
		leia(salario_bruto)
		descontoInss = calculaDescontoInss(salario_bruto)
		escreva("O valor desconto de Inss do seu salario é de:","  ",descontoInss)
		escreveLinha()
		retorna_menu()
	}
	funcao simulador_calculo_ferias()
	{
	     real valor_ferias=0.0
		real total_ferias
		real salario_bruto
		escreva("Informe o seu salario:\n")
		leia(salario_bruto)
		total_ferias = calculoFerias(salario_bruto)
		escreva("O valor das suas férias é de:","R$",total_ferias)
		escreveLinha()
		retorna_menu()
	}
	funcao simulador_adicional_noturno()
	{
          const inteiro HORAS_CONTRATUAIS =220
          const real PERCENTUAL_ADICIONAL = 0.2
          real salario_bruto
          real valor_adicional
          real valorAdicionalNoturno
          real salarioAdicionado
          inteiro horasNoturnasTrabalhadas
          escreva("Informe seu salario:\n")
          leia(salario_bruto)
          escreva("Informe as horas noturnas trabalhadas:\n")
          leia(horasNoturnasTrabalhadas)
         valorAdicionalNoturno = calculaAdicionalNoturno(salario_bruto,horasNoturnasTrabalhadas)*PERCENTUAL_ADICIONAL
         salarioAdicionado = valorAdicionalNoturno+salario_bruto
         escreva("Seu salario adicionado as horas noturnas trabalhadas é de:"," ",salarioAdicionado)
          escreveLinha()
          retorna_menu()
	}
	funcao simulador_horas_extras()
	{
		
	     real salario_bruto
	     inteiro horas_adicionais
	     const inteiro HORA_MENSAL = 220
	     real total_extra
             escreva("Informe seu salario Bruto:\n")
	     leia(salario_bruto)
	     escreva("Informe o total de horas extras trabalhadas:\n")
	     leia(horas_adicionais)
	     total_extra =  calculaValorHoraExtra(salario_bruto,horas_adicionais)
	     escreva("Seu salário adicionado as hora extras é de:",total_extra)
	     escreveLinha()
	     retorna_menu()
	     
	}
	funcao simulador_adicional_periculosidade()
	{
	 real salarioBruto
	  real adicionalPericulo
          escreva("Informe seu salário Bruto:\n")
          leia(salarioBruto)
          adicionalPericulo = salarioBruto*0.3
          escreva("Seu salario somado a periculosidade/mes é de:",adicionalPericulo+salarioBruto)
          escreva("\nSeu adicional de periculosidade é de:",adicionalPericulo)
	}
	funcao simulador_contribuicao_fgts()
     {
     	real salario_bruto,contribuicao
     	inteiro meses
     	real fgts
     	escreva("Informe seu salario:\n")
     	leia(salario_bruto)
     	fgts = salario_bruto*0.08
     	escreva("\nInforme o numero de meses trabalhados:\n")
     	leia(meses)
     	contribuicao = fgts*meses
     	escreva("Sua contribuição atual é de:",contribuicao,",","sendo contribuido (R$)",fgts,"por mes.\n")
     	escreveLinha()
     	retorna_menu()
     
     }
     funcao simulador_multa_fgts()
     {
       real valorSalario=0.0
       inteiro meses=0
       real fgts
       real multaFgts
       real fgtsTotal
       
       fgts =  valorSalario*0.08
       fgtsTotal = contribuicaoFgts(fgts,meses)
       multaFgts =  fgtsTotal*0.2
       escreva("Seu deposito extra sobre o FGTS é de","R$",multaFgts)
       escreveLinha()
       retorna_menu()
     }
     funcao simulador_pis()
     {
     	const real VALOR_MES =  108.50
     	real valorPis
     	real salario
     	inteiro meses
     	escreva("Informe seu salario:\n")
     	leia(salario)

     	se(salario<2604.0)
     	{
     		escreva("Sinto muito voce não tem direito ao beneficio Pis.")
     		escreveLinha()
     		retorna_menu()
     	}
     	senao se(salario>=2604.0)
     	{
     		
               para(inteiro cont=1;cont<2;cont++)
               {
               	escreva("informe quantos meses voce trabalhou: ")
                    leia(meses)
                    valorPis = VALOR_MES*meses
               	escreva("O valor que esta disponivel de beneficio do Pis é de:",valorPis)
               	escreveLinha()
     		     retorna_menu()
               }
     	}
     }
     funcao simulador_seguro_desemprego()
     {
              real salario1,salario2,salario3
              real valor_parcela
              escreva("informe o valor dos 3 ultimos salários recebidos:\n")
              escreva("Salario 1:\n")
              leia(salario1)
              escreva("Salario 2:\n")
              leia(salario2)
              escreva("Salario 3:\n")
              leia(salario3)
              valor_parcela = calculaSeguroDesemprego(salario1,salario2,salario3)
              escreva("O valor da parcela do seu seguro desemprego é de:","R$",valor_parcela)
     }
     funcao simulador_imposto_de_renda()
     {
     	real valor_salario
     	real valor_imposto_de_renda
     	escreva("Informe seu salário:\n")
     	leia(valor_salario)
     	valor_imposto_de_renda = calculaValorDoImpostodeRenda(valor_salario)
     	escreva("O valor do desconto do imposto de renda é:","R$",valor_imposto_de_renda)
     	escreveLinha()
     	retorna_menu()
     }
     funcao simulador_vale_transporte()
     {
     	const real PERCENTUAL_DESCONTO = 0.06
     	real salario_bruto
     	real valor_desconto
     	escreva("informe seu salário:\n")
     	leia(salario_bruto)
     	valor_desconto = calculaDescontoValeTrasporte(salario_bruto)
          valor_desconto = M.arredondar(valor_desconto,2)
          escreva("O valor descontado de vale transporte é de:",valor_desconto)
          escreveLinha()
          escreva("Deseja saber se o beneficio do Vale Transporte é viavel?\n")
          escreva("Caso sim, Digite o numero 1.\n")
          escreva("caso contrário digite 3 e será direcionado(a) ao menu de operaçoes.\n")
          escreva("Digite um numero:\n")
          leia(operacao_cliente)

         se(operacao_cliente == 1)
         {
           real salario_descontado
           salario_descontado = verificaSeCompensaValeTransporte(salario_bruto)
           se(valor_desconto>salario_descontado)
           {
           	escreva(" Não Compensa utilizar do vale transporte.")
           }
           senao 
           {
            escreva("Compensa fazer da utilização do beneficio.")
            retorna_menu()
           }
         }
         senao
         {
         	retorna_menu()
         }
     	
     }
     funcao simulacao_completa()
     {
         limpa()
         real salario_bruto
         inteiro horas_adicionais
         inteiro horasNoturnasTrabalhadas
         real hora_extra
         real noturno
         cadeia opcao
         real possui_periculosidade = 0.0
         real possui_vale_trasporte = 0.0
         real total_adicional
         real total_desconto
         real salario_liquido
         real inss
         real irrf
         real fgts
         real vale_transporte
         
         escreva("\n============DADOS==============\n")
         escreva("Salario Bruto = ","R$")
         leia(salario_bruto)
         escreva("Horas Extras=    ")
         leia(horas_adicionais)
         escreva("Noturno:    ")
         leia(horasNoturnasTrabalhadas)
         escreva("Possui adicional de periculosidade?(SIM/NAO):\n")
         leia(opcao)
    	    opcao = Te.caixa_alta(opcao)
          
         se(opcao =="SIM")
         {
         	 possui_periculosidade = adicional_periculosidade(salario_bruto)
         	 possui_periculosidade = M.arredondar(possui_periculosidade,2)
         }
         senao se(opcao =="NAO")
         {
         	 possui_periculosidade = 0.0
         }
         senao
         {
         	 escreva("Informe uma opção valida.\n")
         	 simulacao_completa()
         }
         escreva("Utiliza Vale transporte: (SIM/NAO):\n")
         leia(opcao)
         opcao = Te.caixa_alta(opcao)
          
         
         se(opcao =="SIM")
         {
         	 possui_vale_trasporte = calculaDescontoValeTrasporte(salario_bruto)
         	 possui_vale_trasporte = M.arredondar(possui_vale_trasporte,2)
         	 
         }
           senao se(opcao =="NAO")
         {
         	  possui_vale_trasporte = 0.0
         }
         senao
         {
         	 escreva("Informe uma opção valida.\n")
         	 simulacao_completa()
         } 

         hora_extra = calculaValorHoraExtra(salario_bruto,horas_adicionais)-salario_bruto
         hora_extra = M.arredondar( hora_extra,2)
         noturno = calculaAdicionalNoturno(salario_bruto,horasNoturnasTrabalhadas)
         noturno = M.arredondar(noturno,2)
         
         escreva("Periculosidade:  ",possui_periculosidade,"\n")
         escreva("Vale transporte:   ",possui_vale_trasporte,"\n")
         escreveLinha()
         escreva("\n=======DETALHAMENTO============\n")
         escreva("Salario Base:  ",salario_bruto)
         escreva("\n")
         escreva("Horas Extras :  ",hora_extra,"\n")
         escreva("Noturno:   ",noturno,"\n")
        
     
         total_adicional = possui_periculosidade+possui_vale_trasporte+hora_extra+noturno
         fgts = calculaFgtsDoMes(salario_bruto)
         fgts = M.arredondar(fgts,2)
         inss = calculaDescontoInss(salario_bruto)
         inss = M.arredondar(inss,2)
         irrf = calculaValorDoImpostodeRenda(salario_bruto)
         irrf = M.arredondar(irrf,2)
         total_desconto = possui_vale_trasporte+irrf+inss
         salario_liquido = salario_bruto+total_adicional

         
         escreva("FGTS:     ",fgts,"\n")
         escreva("Vale transporte:   ",possui_vale_trasporte,"\n")
         escreva("INSS     -:",inss,"\n")
         escreva("IRRF     -:",irrf,"\n")
         escreva("\n")
         escreva("\n---------RESULTADO------------\n")
         escreva("\nTotal adicional   :",total_adicional)
         escreva("\nTotal descontos   -:",total_desconto)
         escreveLinha()
         escreva("Salário Liquído: ",salario_liquido)
         escreveLinha()
         retorna_menu()
     }
     funcao cadastro_cliente()    
    {
    	 
    	  cadeia nome_completo 
    	  cadeia endereco
    	  cadeia telefone 
    	  cadeia idade_cliente 
    	  cadeia cep_usuario 
    	  cadeia cep
    	  cadeia valor_cep
    	  inteiro caracteres
    	  cadeia endereco_sem_cep
    
    	  
    	     para(inteiro cont=0;cont<10;cont++)
    	     {
    	        escreva("\nInforme o nome da pessoa:",cont++,"\n")
    	   	   leia(nome_completo)
    	   	   escreva("\ninforme sua idade:\n")
    	   	   leia(idade_cliente)
    	   	   escreva("Informe seu telefone:\n")
    	   	   leia(telefone)
    	   	   escreva("\nInforme o CEP:\n")
    	   	   leia(cep)
    	      
		  
		   endereco = S.obter_dados("https://viacep.com.br/ws/"+ cep +"/json/")  
		   caracteres = Te.numero_caracteres(endereco)
		   endereco_sem_cep = Te.extrair_subtexto(endereco, 22 , caracteres)
		   endereco_sem_cep = Te.substituir(endereco_sem_cep, "," , "\n")
		   endereco_sem_cep = Te.substituir(endereco_sem_cep, "\"" , "")
    	   	   escreva("Endereco: ",endereco_sem_cep)
    	   	   escreva("\n--------------------\n")
    	     

    	    
    	     
    	     	const cadeia CAMINHO = "./BancoDeDados.txt"
    	     	inteiro opcao
    	     	
    	     	escreva("========OPERAÇOES=========\n")
    	     	escreva("(1)-PARA CADASTRAR OS DADOS NO SISTEMA.\n")
    	     	escreva("(2)-PARA ACRESCENTAR CADASTRO.\n")
    	     	leia(opcao)
    	     	se(opcao == 1)
    	     	{
    	     		inteiro arquivo = arq.abrir_arquivo(CAMINHO,arq.MODO_ESCRITA)
                    arq.escrever_linha("===========BANCO DE DADOS===========\n",arquivo)
                    arq.escrever_linha("NOME:", arquivo)
                    arq.escrever_linha(nome_completo,arquivo)
                    arq.escrever_linha("IDADE:",arquivo)
                    arq.escrever_linha(idade_cliente,arquivo)
                    arq.escrever_linha("ENDEREÇO:",arquivo)
                    arq.escrever_linha(endereco_sem_cep,arquivo)
                    arq.escrever_linha("TELEFONE:",arquivo)
                    arq.escrever_linha(telefone,arquivo)
                    arq.escrever_linha("\n",arquivo)
                    arq.escrever_linha("\n=====================================\n",arquivo)
                    
                    arq.fechar_arquivo(arquivo)

    	     	}
    	     	senao se(opcao == 2)
    	     	{
    	     			
    	     			
    	     			inteiro arquivo = arq.abrir_arquivo(CAMINHO,arq.MODO_ACRESCENTAR)
    	     			arq.escrever_linha("NOME:", arquivo)
                         arq.escrever_linha(nome_completo,arquivo)
                         arq.escrever_linha("IDADE:",arquivo)
                         arq.escrever_linha(idade_cliente,arquivo)
                         arq.escrever_linha("ENDEREÇO:",arquivo)
                         arq.escrever_linha(endereco_sem_cep,arquivo)
                         arq.escrever_linha("TELEFONE:",arquivo)
                         arq.escrever_linha(telefone,arquivo)
                         arq.escrever_linha("\n",arquivo)
                         arq.escrever_linha("\n=====================================\n",arquivo)
                    
                          arq.fechar_arquivo(arquivo)
    	     		  
    	     	}
    	     	senao
    	     	{

    	            retorna_menu()
    	     	}
    	     	
    	     	
    	     }
    	   
    	   	
    	   	
    	  
    }
     funcao real calculaSeguroDesemprego(real salario1,real salario2,real salario3)
     {
     	
     	real media_salario
     	real seguro_desemprego
     
               media_salario = (salario1+salario2+salario3)/3
               
               se(media_salario<=1986.36)
               {
               	seguro_desemprego = media_salario*0.80
               	retorne seguro_desemprego
               }
               senao se(media_salario<=3280.93)
               {
               	seguro_desemprego = (media_salario*0.50)+1574.69
               	retorne seguro_desemprego
               }
               senao
               {
               	seguro_desemprego = 2230.97
               	retorne seguro_desemprego
               }
     	
         
     }
	funcao real calculaDescontoInss(real salario_bruto)
	{
		real salarioMinimo = 1302.0
		real desconto
		se(salario_bruto<=salarioMinimo)
          {
               desconto = (salario_bruto*0.075)
               retorne desconto
          }
          senao se(salario_bruto<=2571.29)
          {
          	desconto =  (salario_bruto*0.09)
          	retorne desconto
          }
		senao se(salario_bruto<=3856.94)
		{
			desconto =  (salario_bruto*0.12)
          	retorne desconto
		}
		senao
		{
			desconto =  (salario_bruto*0.14)
          	retorne desconto
		}
		 
		
	}
	funcao real calculoFerias(real salario_bruto)
	{
		
		real valor_ferias
	     valor_ferias = (salario_bruto/3)+salario_bruto - calculaDescontoInss(salario_bruto)-calculaValorDoImpostodeRenda(salario_bruto)
          retorne valor_ferias
          
	}
	funcao real calculaAdicionalNoturno(real salario_bruto,inteiro horasNoturnasTrabalhadas)
     {
          const inteiro HORAS_CONTRATUAIS =220
          real valor_adicional
	     valor_adicional = (salario_bruto/HORAS_CONTRATUAIS)
          retorne (salario_bruto/HORAS_CONTRATUAIS)*horasNoturnasTrabalhadas
    
	   
     }
	funcao real adicional_periculosidade(real salario_bruto)
	{
		real adicionalTotal = salario_bruto*0.3
		retorne adicionalTotal
	}
	funcao real contribuicaoFgts(real salario_bruto,inteiro meses)
     {
     	real fgts     
     	real contribuicao_fgts

     	fgts =salario_bruto*0.08
          contribuicao_fgts =  fgts*meses
          retorne  fgts*meses
     }
     funcao real calculaFgtsDoMes(real salario_bruto)
     {
     	real fgts     
     	real contribuicao_fgts

     	fgts =salario_bruto*0.08
          contribuicao_fgts =  fgts
          retorne  fgts
     }
     funcao real calculaValorDoImpostodeRenda(real salario_bruto)
     {
     	
     	
     	real impostoRenda
     	real descontoImpostoDeRenda

          impostoRenda = salario_bruto- calculaDescontoInss(salario_bruto)
         
     	se(salario_bruto<1903.98)
     	{
     		descontoImpostoDeRenda = 0.0
     		retorne descontoImpostoDeRenda
     	}
     	senao se(salario_bruto<=2826.65)
     	{
     		
     		descontoImpostoDeRenda = (impostoRenda*7.5/100)
     		retorne descontoImpostoDeRenda
     	}
     	senao se(salario_bruto<=3751.05)
     	{
     		descontoImpostoDeRenda = (impostoRenda*15/100)
     		retorne descontoImpostoDeRenda
     	}
     	senao se(salario_bruto<=4664.68)
     	{
     		descontoImpostoDeRenda = (impostoRenda*22.5/100)
     		retorne descontoImpostoDeRenda
     	}
     	senao
     	{
     		descontoImpostoDeRenda = (impostoRenda*27.5/100)
     		retorne descontoImpostoDeRenda
     	}
     }
     funcao real calculaValorHoraExtra(real salario_bruto,inteiro horas_adicionais)
	{    
		const inteiro HORA_MENSAL = 220
		const real EXTRA_50 = 1.5
		const real EXTRA_100 = 1.6
		real valor_extra
		real horaExtraTotal
		real salarioAdicionado=0.0
		
		
	     valor_extra = salario_bruto/HORA_MENSAL
	     escreva("As horas extras trabalhadas envolve finais de semana e feriados:\n")
	     escreva("(Sim) = 1; (Não) = 2.\n")
	     leia(operacao_cliente)

          escolha(operacao_cliente)
          {
          	caso 1: valor_extra = (valor_extra*EXTRA_100)
          	        horaExtraTotal = valor_extra*horas_adicionais
          	        salarioAdicionado = horaExtraTotal+salario_bruto
          	        
          	pare
          	caso 2: valor_extra = (valor_extra*EXTRA_50)
          	        horaExtraTotal = valor_extra*horas_adicionais
          	        salarioAdicionado  = horaExtraTotal+salario_bruto
          	        
          }
          retorne salarioAdicionado
	}
	funcao real calculaDescontoValeTrasporte (real salario_bruto)
     {
     	const real PERCENTUAL_DESCONTO = 0.06
     	real valor_desconto
     	valor_desconto = salario_bruto*PERCENTUAL_DESCONTO
     	retorne valor_desconto
     }
     funcao real verificaSeCompensaValeTransporte(real salario_bruto)
     {
     	const real VALOR_PASSAGEM = 4.60
         	const inteiro VALETRASNP_USADO_POR_DIA = 4 
         	const inteiro DIAS_UTEIS = 20
         	real valor_com
         	real valor_gradual
         	valor_gradual = (VALOR_PASSAGEM*VALETRASNP_USADO_POR_DIA*DIAS_UTEIS)
         	retorne valor_gradual
        
     }
     funcao logico retornaParaSimulacaoCompleta(caracter periculosidade)
     {
     	caracter opcao
     	escreva("Seu salario possui adicional de periculosidade:\n")
     	leia(opcao)
     	se(opcao == 'S')
     	{
     		retorne verdadeiro
     	}
     	senao
     	{
     		retorne falso
     	}
     }
	funcao retorna_menu() 
	{
		
		escreva("deseja voltar ao menu de operaçoes ou ao inicio?\n")
		escreva("\n====OPÇOES====\n")
		escreva("(1)-Menu de operaçoes.\n")
		escreva("(2)-Tela inicial.\n")
		escreva("(3)-encerra Programa.\n")
		escreva("Digite um numero:\n")
		leia(operacao_cliente)
		escolha(operacao_cliente)
		{
			caso 1:  menu_operacoes()
			pare
			caso 2: inicio()
			pare
			caso 3: escreva("Obrigado pela presença!!!")
			pare
		}
	}
	funcao escreveLinha()
	{
		escreva("\n____________________________________________________________\n")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 15084; 
 * @DOBRAMENTO-CODIGO = [33, 84, 95, 107, 126, 143, 153, 169, 184, 213, 227, 238, 275, 473, 499, 526, 534, 543, 548, 557, 566, 602, 631, 638, 649, 663, 683];
 * @PONTOS-DE-PARADA = 396;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */