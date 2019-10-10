import axios from 'axios';

export default axios.create({
    baseURL: `http://beerspecialist.azurewebsites.net/api/beer`,
    headers: {
        'Content-Type': 'application/json',
        // 'Authorization': "JWT " + localStorage.getItem('token')
    },
    // xsrfCookieName: 'csrftoken',
    //xsrfHeaderName: 'X-CSRFToken',
    // withCredentials: true
});