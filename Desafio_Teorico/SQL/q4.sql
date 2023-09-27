SELECT Produto.id, Produto.descricao
    FROM Produto
        LEFT JOIN ProdArmazem ON Produto.id = ProdArmazem.idProduto
        WHERE ProdArmazem.idProduto IS NULL;