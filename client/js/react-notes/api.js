import axios from "axios";
import { handleApiSuccess, handleApiError } from "../shared/api";

const notesApiUrl = "/api/notes";

export const getNotes = () => {
  return axios.get(notesApiUrl).then(response => response.data);
};

export const addNote = note => {
  return axios
    .post(notesApiUrl, note)
    .then(handleApiSuccess)
    .catch(handleApiError);
};

export const deleteNote = id => {
  return axios
    .delete(`${notesApiUrl}/${id}`)
    .then(handleApiSuccess)
    .catch(handleApiError);
};
