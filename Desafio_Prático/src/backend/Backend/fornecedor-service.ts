// fornecedor-service.ts
export interface IFornecedorService {
    getFornecedores(): Array<Fornecedor>;
    addFornecedor(fornecedor: Fornecedor): void;
  }

  