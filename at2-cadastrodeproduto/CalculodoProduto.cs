public class Produto
{
    public int codigo { get; set; }
    public string descricao { get; set; }
    public double aquisicao { get; set; }
    public double porcentagem { get; set; }
   

    public Produto(int codigo,string descricao,double aquisicao,double porcentagem) 
    {
        this.codigo = codigo;
        this.descricao = descricao;
        this.aquisicao = aquisicao;
        this.porcentagem = porcentagem;
        
    }

   public double Calculo(double aquisic,double porcent)
    {

        double result1 = (aquisic * porcent) ;

        double totalV = (result1 / 100.0) + aquisic;

        return totalV;
       
    
    }

}
