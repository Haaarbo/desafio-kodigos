// Importe a biblioteca Vue.js
import Vue from 'vue';

// Defina a interface IFornecedorService
interface IFornecedorService {
  getFornecedores(): Array<Fornecedor>;
  addFornecedor(fornecedor: Fornecedor): void;
}

// Crie um componente Vue
const MeuComponenteVue = Vue.extend({
  // Implemente a interface IFornecedorService
  data() {
    return {
      fornecedorService: null as IFornecedorService | null,
    };
  },
  // ...
});
