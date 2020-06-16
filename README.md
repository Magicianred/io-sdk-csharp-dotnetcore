# io_sdk_csharp_dotnetcore

Versione non ancora definitiva di connettore in dotnet core.  
Da verificare e completare con l'effettiva integrazione con io-sdk.    

## Dati di test  
Lanciare l'sql contenuto nel file _create_table_with_test_data.sql_  

## Per eseguire  
da linea di comando:  
dotnet run "server=<your_bdHost>;user id=<your_bdUser>;password=<your_dbPass>;database=<your_dbName>;" 

## ToDo  
* gestione dell'exception? (vedere come gestirla di ritorno ad io-sdk)  
* leggere i dati di configurazione dal file 'config.json' invece di renderli nella classe  
* creare almeno un metodo di test per la funzione Repository.GetMessages  
