
_main:

;acionamento_simples.c,3 :: 		void main()
;acionamento_simples.c,6 :: 		TRISD = 0;
	CLRF        TRISD+0 
;acionamento_simples.c,7 :: 		PORTD = 0;
	CLRF        PORTD+0 
;acionamento_simples.c,9 :: 		UART1_Init(9600);
	MOVLW       51
	MOVWF       SPBRG+0 
	BSF         TXSTA+0, 2, 0
	CALL        _UART1_Init+0, 0
;acionamento_simples.c,11 :: 		while(1)
L_main0:
;acionamento_simples.c,13 :: 		if(UART1_Data_Ready() == 1)
	CALL        _UART1_Data_Ready+0, 0
	MOVF        R0, 0 
	XORLW       1
	BTFSS       STATUS+0, 2 
	GOTO        L_main2
;acionamento_simples.c,15 :: 		UART1_Read_Text(dados, ']', 10);
	MOVLW       _dados+0
	MOVWF       FARG_UART1_Read_Text_Output+0 
	MOVLW       hi_addr(_dados+0)
	MOVWF       FARG_UART1_Read_Text_Output+1 
	MOVLW       93
	MOVWF       FARG_UART1_Read_Text_Delimiter+0 
	MOVLW       0
	MOVWF       FARG_UART1_Read_Text_Delimiter+1 
	MOVLW       10
	MOVWF       FARG_UART1_Read_Text_Attempts+0 
	CALL        _UART1_Read_Text+0, 0
;acionamento_simples.c,16 :: 		}
L_main2:
;acionamento_simples.c,17 :: 		if(dados[0] == '[')
	MOVF        _dados+0, 0 
	XORLW       91
	BTFSS       STATUS+0, 2 
	GOTO        L_main3
;acionamento_simples.c,19 :: 		if(dados[1] == '1') // LED
	MOVF        _dados+1, 0 
	XORLW       49
	BTFSS       STATUS+0, 2 
	GOTO        L_main4
;acionamento_simples.c,21 :: 		if(dados[2] == '0')  //Nível Lógico
	MOVF        _dados+2, 0 
	XORLW       48
	BTFSS       STATUS+0, 2 
	GOTO        L_main5
;acionamento_simples.c,23 :: 		PORTD.RD0 = 0;
	BCF         PORTD+0, 0 
;acionamento_simples.c,24 :: 		}
L_main5:
;acionamento_simples.c,25 :: 		if(dados[2] == '1')  //Nível Lógico
	MOVF        _dados+2, 0 
	XORLW       49
	BTFSS       STATUS+0, 2 
	GOTO        L_main6
;acionamento_simples.c,27 :: 		PORTD.RD0 = 1;
	BSF         PORTD+0, 0 
;acionamento_simples.c,28 :: 		}
L_main6:
;acionamento_simples.c,29 :: 		}
L_main4:
;acionamento_simples.c,30 :: 		}
L_main3:
;acionamento_simples.c,31 :: 		}
	GOTO        L_main0
;acionamento_simples.c,32 :: 		}
	GOTO        $+0
; end of _main
