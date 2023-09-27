def maior(x, y, matriz):
    for i in range(x):
        for j in range(y):
            if i == 0 and j == 0:
                maior = matriz[i][j]
            else:
                if m[i][j] > maior:
                    maior = matriz[i][j]
    return maior

a = int(input('Quantidade de linhas da matriz:'))
b = int(input('Quantidade de colunas da matriz:'))

m = []
for i in range(a):
    n = []
    for j in range(b):
        n.append(int(input(f'Valor {i+1}x{j+1}: ')))
    m.append(n)    

print('Matriz informada: ')
for i in range(a):
    for j in range(b):
        print(f'[{m[i][j]}]', end='')
    print()

maiorMatriz = maior(a, b, m)
print(f'O maior valor da matriz é {maiorMatriz}!')
