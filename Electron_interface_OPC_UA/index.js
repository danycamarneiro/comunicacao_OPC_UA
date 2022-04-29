// Requisitos para o funcionamento do programa
const electron = require('electron');
const ipc = electron.ipcRenderer;
//---------------------------------------

//-----------Render to Main-------------
//Entidade 1 ON
const ent_1_t = document.getElementById('ent_1_t')
ent_1_t.addEventListener('click', () =>{
    ipc.send('ent_1_t')
})
//Entidade 1 OFF
const ent_1_f = document.getElementById('ent_1_f')
ent_1_f.addEventListener('click', () =>{
    ipc.send('ent_1_f')
})
//Entidade 2 ON
const ent_2_t = document.getElementById('ent_2_t')
ent_2_t.addEventListener('click', () =>{
    ipc.send('ent_2_t')
})
//Entidade 2 OFF
const ent_2_f = document.getElementById('ent_2_f')
ent_2_f.addEventListener('click', () =>{
    ipc.send('ent_2_f')
})

//-----------Main to render-------------
//Entidade 1
ipc.on('Ent_1', (event, message) => {
    document.getElementById('Ent_1').innerHTML = message
});
ipc.on('Ent_2', (event, message) => {
    document.getElementById('Ent_2').innerHTML = message
});
ipc.on('Var1', (event, message) => {
    document.getElementById('Var1').innerHTML = message
});
ipc.on('Var2', (event, message) => {
    document.getElementById('Var2').innerHTML = message
});