//Aplicando conceitos Promises e Fetch

const doSomethingPromise = new Promise((resolve, reject) => {
    setTimeout(function () {
        resolve('First data');
    }, 1000);

});


const doOtherThingPromise = new Promise((resolve, reject) => {
    setTimeout(function () {
        //did something
        resolve('Second data');
    }, 1000);
});

console.log(doSomethingPromise);
//pending
//Fulfiled
//Rejected

//Callbacks 
function doSomething(callback) {
    setTimeout(function () {
        //did something
        callback('First data');
    }, 1000);
}
function doSomething(callback) {
    setTimeout(function () {
        //did something
        callback('Second data');
    }, 1000);
};
doSomethingPromise.then(data => console.log(data));
function doAll() {
    doSomething(function (data) {
        let processedData = data.split('');
        doOtherThing(function (data2) {
            let processedData2 = data2.split('');

            setTimeout(function () {
                console.log(processedData, processedData2);
            }, 1000);
        });
    });
}




const doSomethingPromise = () =>
    new Promise((resolve, reject) => {
        setTimeout(function () {
            //did something
            resolve('First data');
        }, 1000);

    });

const doOtherThingPromise = () =>
    new Promise((resolve, reject) => {
        setTimeout(function () {
            //did something
            resolve('Second data');
        }, 1000);

    });

Promise.all([doSomethingPromise(), doOtherThingPromise()]).then(data => {
    console.log(data[0].split(''));
    console.log(data[1].split(''));
}).catch(err=>{
console.log(err);
})

