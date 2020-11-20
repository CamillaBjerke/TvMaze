//import Vue from 'vue'
import axios from 'axios'

const client = axios.create({
   baseURL: 'http://localhost:5000/api/TvMazeAPI',
   json: true
})

export default {
    getAll() {
        return client.get('/')
    }
}
