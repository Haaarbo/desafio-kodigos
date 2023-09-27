n = int(input('Número: '))
cont = 0
produto = 1

for i in range(n+1):
    cont = 0
    for j in range(1, i+1):
        if i % j == 0:
            cont += 1
    if cont == 2:
        produto *= i

print(f'{produto} é o produto dos primos, de 1 a {n}')
