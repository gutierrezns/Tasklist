import axios from 'axios';

const requester = axios.create({
    baseURL: 'https://localhost:5001/',
    responseType: 'json',
})

export const getAll = async ({ path, body = {} }) => {
    try {
        const res = await requester.get(path, { params: body });
        return res.data;
    } catch (error) {
        console.log("error", error)
    }
}

export const putTask = async ({ path, body = {} }) => {
    try {
        const res = await requester.put(path, { params: body });
        return res.data;
    } catch (error) {
        console.log('requester error')
        console.log("error", error)
    }
}