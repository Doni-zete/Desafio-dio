//Fetch, Async/Await e EventEmitter
fetch('http://localhost:8080/dataXPTO.json', {
    method: 'post',

})
    .then(responseStream => {
        console.log(responseStream)
        if (responseStream.status === 200) {
            return responseStream.json();
        } else {
            throw new Error('Request error');
        }
    })



    //EventEmitter

const EventEmitter = require('events');
class Users extends EventEmitter{
    userLogged(data){
        setTimeout(() =>{
        this.emit('User logged', data);
        },2000);
    }
}

const users =new Users();
users.once('User logged', data => {
    console.log(data);

});
users.userLogged({ user: 'Donizete' });
users.userLogged({ user: 'Pereira ' });


    .then(data => {
        console.log(data);
    })
    .catch(err => {
        console.log('Erro:', err);
    });



//Es7 - Async / Await
const asyncTimer =()=> 
new Promise((resolve,reject)=> {
    setTimeout(()=>{
        resolve(12345);
    },1000);
});


const simpleFunc = async ()=> {
const data = await Promise.all([
    asyncTimer(),
    fetch('/data.json').then(resStream  => resStream.json())

]);

return data;
};
simpleFunc().then(data =>{
    console.log(data);

})
.catch(err =>{
    console.log(err);

});