SELECT ProdArmazem.idProduto, COUNT(DISTINCT ProdArmazem.idArmazem) AS QuantidadeArmazens
    FROM ProdArmazem
        GROUP BY ProdArmazem.idProduto
        ORDER BY QuantidadeArmazens DESC;
