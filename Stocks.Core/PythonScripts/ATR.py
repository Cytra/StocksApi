class ATR:
    from datetime import datetime
    import pandas as pd
    import os
    import io
    import requests
    import requests
    import pandas
    import matplotlib.pyplot as plt
    import numpy as np
    apiKey = 'd625c9cfee28e7538b268960f1a95800'
    stockListUrl = 'https://financialmodelingprep.com/api/v3/stock/list'
    evUrl = 'https://financialmodelingprep.com/api/v3/enterprise-values/'
    listUrl = 'https://financialmodelingprep.com/api/v3/stock/list'
    rationsUrl = 'https://financialmodelingprep.com/api/v3/ratios/'
    historicPriceUrl = 'https://financialmodelingprep.com/api/v3/historical-price-full/'
    incomeStatementGrouthUrl = 'https://financialmodelingprep.com/api/v3/income-statement-growth/'
    incomeStatementUrl = 'https://financialmodelingprep.com/api/v3/income-statement/'
    stockScreenerUrl = 'https://financialmodelingprep.com/api/v3/stock-screener'
    stockScreenerTechUrl = 'https://financialmodelingprep.com/api/v3/stock-screener?marketCapMoreThan=100000000&volumeMoreThan=10000&sector=Technology'
    stockPrice = 'https://financialmodelingprep.com/api/v3/historical-price-full/'
    stockPriceFull = 'https://financialmodelingprep.com/api/v3/historical-price-full/'

    def GetUrl(url):
        result = url + '?apikey=' + apiKey
        return result

    def GetUrl2(url):
        result = url + '&apikey=' + apiKey
        return result

    def GetStockUrl(url, stock, limit):
        result = url + stock + '?' + limit + '&apikey=' + apiKey
        return result

    def GetDf(url):
        r = requests.get(url, headers={'Accept': 'application/json'})
        data = pandas.DataFrame(r.json())
        return data

    def GetEvDf(stock):
        url = GetStockUrl(evUrl,stock,'limit=5')
        return GetDf(url)

    def GetRationsDf(stock, limit):
        url = GetStockUrl(rationsUrl,stock, limit)
        return GetDf(url)

    def GetPrice(stock):
        url = 'https://financialmodelingprep.com/api/v3/historical-price-full/' + stock + '?serietype=line&apikey=' + apiKey
        r = requests.get(url, headers={'Accept': 'application/json'})
        data = pandas.DataFrame(r.json()['historical'])
        #result = data.set_index('date')
        return data

    def GetIncomeStatementGrouthUrl(stock, limit):
        url = GetStockUrl(incomeStatementGrouthUrl,stock, limit)
        return GetDf(url)

    def GetIncomeStatementUrl(stock, limit):
        url = GetStockUrl(incomeStatementUrl,stock, limit)
        print(url)
        return GetDf(url)

    def GetAllStocks():
        url = GetUrl(stockListUrl)
        result = GetDf(url)
        return result

    def GetTechStocks():
        url = GetUrl2(stockScreenerTechUrl)
        result = GetDf(url)
        return result

    def GetPrice(stock):
        url = GetUrl2(stockPrice + stock + '?serietype=line') 
        result = GetDf(url)
        return result

    def GetPriceFull(stock):
        url = GetUrl(stockPriceFull + stock) 
        result = GetDf(url)
        return result


    stockData = GetPriceFull('ASO')
    stockDataPrices = pd.DataFrame(list(stockData['historical']))
    bins = [-100,-20,-15,-10,-5,0,5,10,15,20,100]
    #bins = [-100,-2,-1.5,-1,-0.5,0,0.5,1,1.5,2,100]

    #plt.hist(stockDataPrices['changePercent'], bins =
    #[-2,-1.5,-1,-0.5,0,0.5,1,1.5,2])
    plt.hist(stockDataPrices['changePercent'],bins = [-20,-15,-10,-5,0,5,10,15,20])
    plt.show()

    count = stockDataPrices['changePercent'].count()
    bin_indices = np.digitize(stockDataPrices['changePercent'], bins)
    counts, bin_edges = np.histogram(stockDataPrices['changePercent'], bins=bins)
    countsDf = pd.DataFrame(counts, columns=['Counts'])
    binEdgesDf = pd.DataFrame(bin_edges, columns=['Bins'])
    result = binEdgesDf.join(countsDf)
    result['Probabilities'] = result['Counts'] / count
    result['Cumulative Percentage'] = result['Probabilities'].cumsum()
    result

    averageReturn = stockDataPrices['changePercent'].mean()
    averageReturn * 100

    avgPos = stockDataPrices[stockDataPrices['changePercent'] > 0]['changePercent'].mean()
    avgNeg = stockDataPrices[stockDataPrices['changePercent'] < 0]['changePercent'].mean()
    avgPosCount = stockDataPrices[stockDataPrices['changePercent'] > 0]['changePercent'].count()
    avgNegCount = stockDataPrices[stockDataPrices['changePercent'] < 0]['changePercent'].count()
    avgZeroCount = stockDataPrices[stockDataPrices['changePercent'] == 0]['changePercent'].count()
    dfReturns = pd.DataFrame({'return': [avgPos, avgNeg, 0], 
         'Tytles': ['pos','neg','zero'],
         'Freq': [avgPosCount,avgNegCount,avgZeroCount],
         'Percent': [avgPosCount / sum(counts), avgNegCount / sum(counts), avgZeroCount / sum(counts)],
         'Avg returns' : [avgPos * avgPosCount / sum(counts),avgNeg * avgNegCount / sum(counts),0]
        }).set_index('Tytles')
    dfReturns

    dataDescribe = stockDataPrices['changePercent'].describe()
    dfStd = pd.DataFrame({
            'Tytles': ['Upper','Lower'],
            '1': [dataDescribe['mean'] + dataDescribe['std'], dataDescribe['mean'] - dataDescribe['std']],
            '2': [dataDescribe['mean'] + dataDescribe['std'] * 2, dataDescribe['mean'] - dataDescribe['std'] * 3],
            '3': [dataDescribe['mean'] + dataDescribe['std'] * 3, dataDescribe['mean'] - dataDescribe['std'] * 3]
        }).set_index('Tytles')
    dfStd

    oneActual = stockDataPrices[stockDataPrices['changePercent'].between(dfStd['1']['Lower'],dfStd['1']['Upper'])]['changePercent'].count()
    twoActual = stockDataPrices[stockDataPrices['changePercent'].between(dfStd['2']['Lower'],dfStd['2']['Upper'])]['changePercent'].count()
    threeActual = stockDataPrices[stockDataPrices['changePercent'].between(dfStd['3']['Lower'],dfStd['3']['Upper'])]['changePercent'].count()
    oneNormal = sum(counts) * 0.682
    twoNormal = sum(counts) * 0.954
    threeNormal = sum(counts) * 0.998
    dfStdDist = pd.DataFrame({
        'Tytles': ['1','2','3'],
        'Actual': [oneActual,twoActual,threeActual],
        'Normal': [oneNormal,twoNormal,threeNormal],
        'ActualPer': [oneActual / sum(counts),twoActual / sum(counts),threeActual / sum(counts)],
        'NormalPer': [0.682,0.954,0.998]
    }).set_index('Tytles')
    dfStdDist

    stockDataPrices['HL'] = stockDataPrices['high'] - stockDataPrices['low']
    stockDataPrices['RolingSum'] = stockDataPrices['HL'].rolling(2, min_periods=1).sum()
    stockDataPrices['ATR1D'] = (stockDataPrices['RolingSum'] / 2) / stockDataPrices['open']

    dfAtr = pd.DataFrame({
        '5d%': [stockDataPrices.loc[0:5]['ATR1D'].mean() * 100],
        '20d%': [stockDataPrices.loc[0:20]['ATR1D'].mean() * 100],
        '60d%': [stockDataPrices.loc[0:60]['ATR1D'].mean() * 100],
        '250d%': [stockDataPrices.loc[0:250]['ATR1D'].mean() * 100],
        '3Y%': [stockDataPrices.loc[0:750]['ATR1D'].mean() * 100],
        '5Y%': [stockDataPrices.loc[0:1250]['ATR1D'].mean() * 100],
        '10Y%': [stockDataPrices.loc[0:2500]['ATR1D'].mean() * 100],
        '20Y%': [stockDataPrices.loc[0:5000]['ATR1D'].mean() * 100],
        '50Y%': [stockDataPrices.loc[0:12500]['ATR1D'].mean() * 100],
        'Tytles': ['ATR daily'],
    }).set_index('Tytles')
    dfAtr
