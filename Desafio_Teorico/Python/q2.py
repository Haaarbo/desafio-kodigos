texto = str(input('Insira uma entrada de texto a seguir: \n'))
busca = str(input('\nAgora insira a string a ser buscada: '))

if busca in texto:    
    for c in range(len(texto)):
        tam = c + len(busca)
        p = texto[c:tam]

        if p == busca:
            ocorrencia = c
            print(f'Uma ocorrência encontrada da string "{busca}" no texto: index {ocorrencia} e vai até {ocorrencia+len(busca)-1}.')
            
else:
    print(f'Não há qualquer ocorrência da string {busca} no texto.')
