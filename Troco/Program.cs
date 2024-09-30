decimal vlcompra, vlpago, vltroco;

Console.WriteLine("---Troco---\n");


Console.Write("Valor de Compra:.....");
vlcompra = Convert.ToDecimal (Console.ReadLine());

Console.Write("Valor Pago:....");
vlpago = Convert.ToDecimal (Console.ReadLine());

vltroco = vlpago - vlcompra;

Console.WriteLine($"\n Troco: {vltroco:C}");
