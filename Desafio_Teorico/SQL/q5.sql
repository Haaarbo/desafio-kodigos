SELECT Armazem.nome, SUM(Produto.valor * ProdArmazem.qtd) AS ValorFinanceiro
    FROM Armazem
        JOIN ProdArmazem ON Armazem.id = ProdArmazem.idArmazem
        JOIN Produto ON Produto.id = ProdArmazem.idProduto
        GROUP BY Armazem.nome
        ORDER BY ValorFinanceiro DESC;