import * as React from "react";
import NoteForm from "./NoteForm";
import NotesList from "./NotesList";
import { getNotes, addNote, deleteNote } from "./api";

class Notes extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      notes: []
    };
  }

  componentDidMount() {
    this.loadNotes();
  }

  createNote = note => {
    return addNote(note).then(res => {
      if (res.ok) {
        this.loadNotes();
      } else {
        return res.errors;
      }
    });
  };

  loadNotes() {
    getNotes().then(notes => {
      this.setState({ notes: notes });
    });
  }

  deleteNote = note => {
    return deleteNote(note.id).then(res => {
      if (res.ok) {
        this.loadNotes();
      } else {
        return res.errors;
      }
    });
  };

  render() {
    return (
      <div className="row">
        <div className="col-sm-6">
          <h4>Add note</h4>
          <NoteForm handleSave={this.createNote} />
        </div>
        <div className="col-sm-6">
          <h4>Notes</h4>
          <NotesList notes={this.state.notes} handleDelete={this.deleteNote} />
        </div>
      </div>
    );
  }
}

export default Notes;
