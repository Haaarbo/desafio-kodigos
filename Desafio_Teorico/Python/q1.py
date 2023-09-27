a1 = []
a2 = []
a3 = []
aux = []
qtd = int(input('Quantos elementos serão adicionados ao primeiro vetor? '))
for c in range(qtd):
    a1.append(int(input('Número: ')))

print('-='*30)

qtd = int(input('Quantos elementos serão adicionados ao segundo vetor? '))
for c in range(qtd):
    a2.append(int(input('Número: ')))

for c in a1:
    aux.append(c)
for c in a2:
    aux.append(c)

for pos, val in enumerate(aux):
    if pos == 0 or val > a3[-1]:
        a3.append(val) 
    else:
        cont = 0
        while cont < len(a3):
            if val <= a3[cont]:
                a3.insert(cont, val)
                break
            cont += 1
print('-='*30)
print(f'Vetor ordenado: {a3}')
