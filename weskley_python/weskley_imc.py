nome = input('Nome: ')
peso = float(input('Peso: '))
altura = float(input('Altura: '))
imc = float((peso)/(altura * altura))
print("Imc: ", imc)
if imc < 17.0:
    print("Muito abaixo do peso")
elif imc >= 17.0 and imc <= 18.49:
    print("Abaixo do peso")
elif imc >= 18.5 and imc <= 24.99:
    print("Peso normal")
elif imc >= 25.0 and imc <= 29.99:
    print("Acima do peso")
elif imc > 30.0:
    print("Obesidade")
