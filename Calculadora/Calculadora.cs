namespace Lab.Calculadora;

public class Calculadora
{
    private List<string> listahistorico;
    private DateTime _data;

    public Calculadora(DateTime data)
    {
        listahistorico = new List<string>();
        _data = data;
    }

    public int somar(int val1, int val2)
    {
        int res = val1 + val2;
        listahistorico.Insert(0, $"{_data} | {val1} + {val2} = {res}");
        return res;
    }

    public int subtrarir(int val1, int val2)
    {
        int res = val1 - val2;
        listahistorico.Insert(0, $"{_data} | {val1} - {val2} = {res}");
        return res;
    }

    public int multiplicar(int val1, int val2)
    {
        int res = val1 * val2;
        listahistorico.Insert(0, $"{_data} | {val1} * {val2} = {res}");
        return res;
    }

    public int dividir(int val1, int val2)
    {
        int res = val1 / val2;
        listahistorico.Insert(0, $"{_data} | {val1} - {val2} = {res}");
        return res;
    }

    public List<string> historico()
    {
        listahistorico.RemoveRange(3, listahistorico.Count-3);
        return listahistorico;
    }
}
