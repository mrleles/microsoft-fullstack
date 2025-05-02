async function fetchDataAsync() {
    try {
        const response = await fetch('https://jsonplaceholder.typicode.com/users');
        const data = await response.json();
        const container = document.getElementById('data-container');
        container.innerHTML = data.map(user => `<p>${user.name} - ${user.email}</p>`).join('');
    } catch (error) {
        console.error('Error fetching data:', error);
    }
}

document.getElementById('fetch-data').addEventListener('click', fetchDataAsync);