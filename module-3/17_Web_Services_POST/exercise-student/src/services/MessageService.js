import axios from 'axios';

const http = axios.create({
  baseURL: "http://localhost:3000"
});

export default {

  get(id) {
    return http.get(`/messages/${id}`);
  },

  postMessage(newMessage) {
    return http.post('/messages', newMessage);
  },

  updateMessage(messageToUpdate) {
    return http.put(`/messages/${messageToUpdate.id}`, messageToUpdate);
  },

  deleteMessageFunc(messageId) {
    return http.delete(`/messages/${messageId}`);
  }

}
