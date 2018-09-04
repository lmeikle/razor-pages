import * as React from "react";
import { Form, Field } from "react-final-form";
import { TextInput } from "../components/TextInput";
import { TextArea } from "../components/TextArea";

const NoteForm = props => {
  return (
    <Form
      onSubmit={props.handleSave}
      render={props => {
        const { handleSubmit, pristine, submitting, submitError, form } = props;
        return (
          <form
            onSubmit={e =>
              handleSubmit(e).then(res => {
                if (!res) {
                  form.reset();
                }
              })
            }
          >
            {submitError && (
              <div className="alert alert-danger">{submitError}</div>
            )}
            <Field name="Title" component={TextInput} placeholder="Title" />
            <Field
              name="Content"
              component={TextArea}
              placeholder="Content"
              rows="5"
            />
            <div className="float-right">
              <button
                type="submit"
                className="btn btn-primary"
                disabled={submitting || pristine}
              >
                Create note
              </button>
            </div>
          </form>
        );
      }}
    />
  );
};

export default NoteForm;
