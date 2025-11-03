import csv
from pathlib import Path
CAMINHO_CSV = Path(__file__).parent / 'trabalho_osa_excel.csv'

# comissao -> cada vendedor tem direito a 7% do valor da venda
def calcular_comissao(venda: float) -> float:
    return venda * 0.07 # 7% da venda

# Lucro -> Vendas - comissao
def calcular_lucro(venda: float, comissao: float) -> float:
    return venda - comissao

# Porcentagem de cada lucro do vendedor em relação ao total
def calcular_porcentagem(lucro_vendedor: float, total: float) -> str:
    return f"{(lucro_vendedor / total) * 100:,.2f} %"

# Total -> Soma de todos os lucros
def calcular_lucros(lucros: list[int|float]) -> float:
    return sum(lucros)

def relatorio_final(dados: dict):
    total_vendedores = len(dados['nome'])

    # povoa a lista de comissao, lucro, porcentagem
    for x in range(total_vendedores - 1):
        dados['comissao'].append(0)
        dados['lucro'].append(0)
        dados['porcentagem'].append(0)

    # infelizmente ainda não é possivel calcular a procentagem
    for x in range(total_vendedores - 1):
        # dados de entrada
        venda = dados['vendas'][x]
        
        # Calculando a comissao e o lucro
        comissao = calcular_comissao(venda)
        lucro = calcular_lucro(venda, comissao)

        # Altera os dados com o resultado do processo
        dados['comissao'][x] = comissao
        dados["lucro"][x] = lucro

    # calcula a somatoria de todos os lucros
    dados['total'] = calcular_lucros(dados['lucro'])

    # como ja temos o valor total podemos descobrir a procentagem para cada vendedor
    for x in range(total_vendedores - 1):    
        dados['porcentagem'][x] = calcular_porcentagem(dados['lucro'][x], dados['total'])
    
    return dados

def gerar_excel(dados: dict):
    # criar linha de cabeçalho
    cabecalho = []
    for coluna in dados.keys():
        if coluna.lower() == 'total':
            continue
        cabecalho.append(coluna)
    
    # criar linha de dados
    linha_de_dados = []
    for x in range(len(dados['nome']) - 1):
        nome = dados['nome'][x]
        vendas = f"{dados['vendas'][x]:,.2f}"
        comissao = f"{dados['comissao'][x]:,.2f}"
        lucro = f"{dados['lucro'][x]:,.2f}"
        porcentagem = dados['porcentagem'][x]
        linha = [nome, vendas, comissao, lucro, porcentagem]
        linha_de_dados.append(linha)
    
    with open(CAMINHO_CSV, mode="w", newline="", encoding="utf-8") as arquivo:
        escritor = csv.writer(arquivo, dialect='excel', delimiter=';')
        escritor.writerow(cabecalho)
        for linha in linha_de_dados:
            escritor.writerow(linha)
        escritor.writerow(["", "", "Total", f"{dados['total']:,.2f}"])

    print("Processo concluido com sucesso.")    

if __name__ == "__main__":
    # dados do desafio
    dados = {
        "nome": ["Fernanda", "Carlos", "Rafael", "Tamires", "Daniel", "Maria"],
        "vendas": [3248.85, 5466.45, 3653.46, 5384.58, 3958.54, 3845.45],
        "comissao": [],
        "lucro": [],
        "porcentagem": []
    }

    excel = relatorio_final(dados)
    gerar_excel(excel)
