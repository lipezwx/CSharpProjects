char dados[5];

void main() {
    TRISD = 0;
    PORTD = 0;

    UART1_Init(9600);

    while(1) {
        if(UART1_Data_Ready() == 1) {
            UART1_Read_Text(dados, "]", 10);

            if(dados[0] == '[') {
                if(dados[1] == '1') { // LED
                    if(dados[2] == '0') {  //Nível Lógico
                        PORTD.RD0 = 0;
                    }
                    if(dados[2] == '1') {  //Nível Lógico
                        PORTD.RD0 = 1;
                    }
                }
            }
        }
    }
}
