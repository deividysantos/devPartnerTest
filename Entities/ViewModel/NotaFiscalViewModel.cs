using System;

namespace devPartnerTest.Entities.ViewModel
{
    public class NotaFiscalViewModel
    {
        public int notaFiscalId { get; set; }
        public int numeroNf { get; set; }
        public double valorTotal { get; set; }
        public DateTime dataNf { get; set; }
        public string cnpjEmissorNf { get; set; }
        public string cnpjDestinatarioNf { get; set; }
    }
}