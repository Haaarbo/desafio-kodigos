SELECT Armazem.id, Armazem.nome, SUM(ProdArmazem.qtd * Produto.tamanho) 
    AS "Espaço Total Ocupado"
    FROM Armazem
        JOIN ProdArmazem ON Armazem.id = ProdArmazem.idArmazem
        JOIN Produto ON ProdArmazem.idProduto = Produto.id
        GROUP BY Armazem.id, Armazem.nome;
