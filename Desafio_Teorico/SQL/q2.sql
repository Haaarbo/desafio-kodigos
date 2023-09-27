SELECT Armazem.nome, ProdArmazem.qtd
    FROM ProdArmazem
        JOIN Armazem ON ProdArmazem.idArmazem = Armazem.id
        WHERE ProdArmazem.idProduto = <id_do_produto>
        ORDER BY ProdArmazem.qtd DESC
        LIMIT 5;
    