function fetchDataWithCallback(callback) {
    const xhr = new XMLHttpRequest();
    xhr.open('GET', 'https://jsonplaceholder.typicode.com/users', true);
    xhr.onload = function () {
        if (xhr.status === 200) {
            callback(null, JSON.parse(xhr.responseText));
        } else {
            callback('Error fetching data', 'null');
        }
    };
    xhr.send();
}

fetchDataWithCallback((error, data) => {
    if (error) {
        console.error(error);
    } else {
        console.log(data);
    }
});