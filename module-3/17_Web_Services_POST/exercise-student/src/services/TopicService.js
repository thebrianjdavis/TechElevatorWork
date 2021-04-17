import axios from 'axios';

const http = axios.create({
  baseURL: "http://localhost:3000"
});

export default {

  list() {
    return http.get('/topics');
  },

  get(id) {
    return http.get(`/topics/${id}`);
  },

  postTopic(newTopic) {
    return http.post('/topics', newTopic);
  },

  updateTopic(topicToUpdate) {
    return http.put(`/topics/${topicToUpdate.id}`, topicToUpdate);
  },

  deleteTopicFunc(topicId) {
    return http.delete(`/topics/${topicId}`);
  }

}
