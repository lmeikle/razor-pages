import * as React from "react";
import NoteCard from "./NoteCard";

const NotesList = ({ notes, handleDelete }) => {
  return notes.length > 0 ? (
    <div>
      {notes.map(n => (
        <NoteCard key={n.id} note={n} handleDelete={handleDelete} />
      ))}
    </div>
  ) : (
    <em>There are currently no notes</em>
  );
};

export default NotesList;
