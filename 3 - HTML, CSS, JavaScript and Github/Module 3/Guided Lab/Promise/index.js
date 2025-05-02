function fetchDataWithPromise() {
    return new Promise((resolve, reject) => {
        const xhr = new XMLHttpRequest();
        xhr.open('GET', 'https://jsonplaceholder.typicode.com/users', true);
        xhr.onload = function () {
            if (xhr.status === 200) {
                resolve(JSON.parse(xhr.responseText));
            } else {
                reject('Error fetching data');
            }
        };
        xhr.send();
    });
}

fetchDataWithPromise().then(data => console.log(data)).catch(error = console.error(error));