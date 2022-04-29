// Requisitos para o funcionamento do programa
const path = require('path');
const {app, BrowserWindow, ipcMain} = require('electron');
const {
    OPCUAClient,
    MessageSecurityMode, SecurityPolicy,
    AttributeIds,
    // makeBrowsePath,
    // ClientSubscription,
    // TimestampsToReturn,
    // ClientMonitoredItem,
    // DataValue,
    DataType
 } = require('node-opcua');
//---------------------------------------
let inty2
let var1
let var2
let var3
let var4

// OPC client
const connectionStrategy = {
    initialDelay: 1000,
    maxRetry: 1
}
const options = {
    applicationName: "MyClient",
    connectionStrategy: connectionStrategy,
    securityMode: MessageSecurityMode.None,
    securityPolicy: SecurityPolicy.None,
    endpointMustExist: false,
};
const client = OPCUAClient.create(options);
const endpointUrl = "opc.tcp://ibhlinkua_011088:48010";

let opc_c= setInterval(async() =>{
    try{
        await client.connect(endpointUrl);
        const session = await client.createSession();
        var1 = await session.read({nodeId:"ns=6;i=6005", attributeId:AttributeIds.Value});
        try{var1=var1.value.value}catch{};
        var2 = await session.read({nodeId:"ns=6;i=6017", attributeId:AttributeIds.Value});
        try{var2=var2.value.value}catch{};
        var3 = await session.read({nodeId:"ns=7;s=.Publish.teste.struct1.u1", attributeId:AttributeIds.Value});
        try{var3=var3.value.value}catch{};
        var4 = await session.read({nodeId:"ns=7;s=.Publish.teste.struct1.u2", attributeId:AttributeIds.Value});
        try{var4=var4.value.value}catch{};
        await session.close();
        await client.disconnect();
    }
    catch(err){
        console.log(err)
        await client.disconnect();}
},1000)
//-------------------------------------
const createWindow = () => {
    let mainWindow = new BrowserWindow({
        webPreferences: {
            nodeIntegration: true,
            contextIsolation: false,
        }
    });
    mainWindow.loadFile(path.join(__dirname, "./mainWindow.html"));
    //mainWindow.webContents.openDevTools();

    //-----------Visualização das variáveis OPC UA-------------
    inty2 = setInterval(() =>{
        mainWindow.webContents.send('Ent_1',var3);
        mainWindow.webContents.send('Ent_2',var4);
        mainWindow.webContents.send('Var1',var1);
        mainWindow.webContents.send('Var2',var2);
    },20)
}

// Inicia a aplicação quando ready
app.on('ready', createWindow);

app.on('window-all-closed', () =>{
    if(process.platform!=='darwin'){
        app.quit();
        clearInterval(inty2);
        clearInterval(opc_c);
    }
})
app.on('activate', () => {
    if(BrowserWindow.getAllWindows().length ===0){
        createWindow()
    }
})

//-----------Adicionar interações-------------
//Entidade 1 ON
ipcMain.on('ent_1_t', async(event) =>{
    //send action to opc
    try{
        await client.connect(endpointUrl);
        const session = await client.createSession();
        await session.write({nodeId:"ns=7;s=.Publish.teste.struct1.u1", attributeId:AttributeIds.Value, indexRange:null, value:{value:{dataType:DataType.Boolean,value: true}}})
        await session.close();
        await client.disconnect();
    }
    catch(err){
        console.log(err)
        await client.disconnect();}
})
//Entidade 1 OFF
ipcMain.on('ent_1_f', async(event) =>{
    //send action to opc
    try{
        await client.connect(endpointUrl);
        const session = await client.createSession();
        await session.write({nodeId:"ns=7;s=.Publish.teste.struct1.u1", attributeId:AttributeIds.Value, indexRange:null, value:{value:{dataType:DataType.Boolean,value: false}}})
        await session.close();
        await client.disconnect();
    }
    catch(err){
        console.log(err)
        await client.disconnect();}
})
//Entidade 2 ON
ipcMain.on('ent_2_t', async(event) =>{
    //send action to opc
    try{
        await client.connect(endpointUrl);
        const session = await client.createSession();
        await session.write({nodeId:"ns=7;s=.Publish.teste.struct1.u2", attributeId:AttributeIds.Value, indexRange:null, value:{value:{dataType:DataType.Boolean,value: true}}})
        await session.close();
        await client.disconnect();
    }
    catch(err){
        console.log(err)
        await client.disconnect();}
})
//Entidade 2 OFF
ipcMain.on('ent_2_f', async(event) =>{
    //send action to opc
    try{
        await client.connect(endpointUrl);
        const session = await client.createSession();
        await session.write({nodeId:"ns=7;s=.Publish.teste.struct1.u2", attributeId:AttributeIds.Value, indexRange:null, value:{value:{dataType:DataType.Boolean,value: false}}})
        await session.close();
        await client.disconnect();
    }
    catch(err){
        console.log(err)
        await client.disconnect();}
})
