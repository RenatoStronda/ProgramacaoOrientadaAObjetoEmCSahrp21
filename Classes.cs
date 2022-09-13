namespace Classes{
    public class Arma{
        public int quantidadeBalas;

        public bool atirar(){
            if(quantidadeBalas > 0){
            this.quantidadeBalas --;
            return true;
            }
            else{
                return false;
            }
        }
        public bool recarregar(int quantidadeBalas){
            if(this.quantidadeBalas == 0){
            this.quantidadeBalas = quantidadeBalas;
            //this.quantidadeBalas ++;
            return true;
            }
            else{
                return false;
            }
        }
        public int getQuantidadeBalas(){
            return this.quantidadeBalas;
        }
    }
}
/*5- Crie uma classe Arma que possui um atributo: quantidadeBalas : int. Implemente o método atirar() que quando invocado, 
decementa o valor do atributo quantidadeBalas. Implemente o método recarregar(int qtd) que recebe como argumento a quantidade 
de balas que recarregará a arma. Implemente o método getQuantidadeBalas() que retorna o valor do atributo quantidadeBalas. 
Ambos os métodos possuem retorno do tipo boolean. Uma arma só atira de quantidadeBalas > 0 e só recarrega se o atributo 
quantidadeBalas < 1;  Logo ao atirar com a arma, se a quantidadeMunicao > 0 entao decremente o atributo quantidadeBalas 
e retorne true, caso contrario nao faca nada e retorna false.*/