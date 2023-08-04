public class Produto
{
    public string codigo;
    public string descricao;
    public double aquisicao;
    public double porcentagem;
    public double valorVenda;

    public Produto(string codigo,string descricao,double aquisicao,double porcentagem,double valorVenda) 
    {
        this.codigo = codigo;
        this.descricao = descricao;
        this.aquisicao = aquisicao;
        this.porcentagem = porcentagem;
        this.valorVenda = valorVenda;
    }

   public string Calculo()
    {

        double result1 = (aquisicao * porcentagem) ;

        valorVenda = (result1 / 100) + aquisicao;

        return valorVenda.ToString("C2");
       
    
    }

}
