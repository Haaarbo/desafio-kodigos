n1 = 0
n2 = 1
termo = 3

n = int(input('Número(s) da sequência de Fibonacci: '))

print(f'Os {n} números da sequência são:')
if n == 1:
    print(f'{n1}')
elif n >= 2:
    print(f'{n1} - {n2} - ', end='')
    while termo <= n:
        n3 = n1 + n2
        print(f'{n3} - ', end='')
        n1 = n2
        n2 = n3
        termo += 1
