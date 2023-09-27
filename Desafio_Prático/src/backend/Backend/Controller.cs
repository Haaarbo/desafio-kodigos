using Microsoft.AspNetCore.Mvc;

namespace MinhaAPI.Controllers
{
    using System.Collections.Generic;

public interface IFornecedorService
{
    List<Fornecedor> GetFornecedores();
    void AddFornecedor(Fornecedor fornecedor);
}

    [ApiController]
    [Route("api/[controller]")]
    public class FornecedoresController : ControllerBase
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedoresController(IFornecedorService fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }
        // Métodos do controlador aqui
    }

    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        // Métodos do controlador aqui
    }

   public interface IFornecedorService
    {
        List<Fornecedor> GetFornecedores();
        void AddFornecedor(Fornecedor fornecedor);
    } 

}
