import * as React from "react";
import * as classNames from "classnames";

export const TextArea = ({ input, meta, label, type, ...rest }) => {
  return (
    <div className="form-group">
      {label && <label htmlFor={input.name}>{label}</label>}
      <textarea
        {...input}
        {...rest}
        className={classNames("form-control", {
          "is-invalid": meta.error || meta.submitError
        })}
      >
        {input.value}
      </textarea>
      {(meta.error || meta.submitError) &&
        meta.touched && (
          <div className="invalid-feedback">
            {meta.error || meta.submitError}
          </div>
        )}
    </div>
  );
};

export const parseStringArrayFromTextArea = value => {
  if (!value) {
    return [];
  }
  // split on newlines
  return value.split(/[\r\n]+/);
};

export const formatStringArrayToTextArea = values => {
  if (!values) {
    return "";
  }
  return values.join("\n");
};
