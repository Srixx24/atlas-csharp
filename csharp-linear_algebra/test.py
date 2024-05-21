def convert_line_endings(file_path, output_path):
    with open(file_path, 'rb') as file:
        content = file.read()
    
    # Replace Windows line endings with Unix line endings
    content = content.replace(b'\r\n', b'\n')
    
    with open(output_path, 'wb') as file:
        file.write(content)

# Convert the files
convert_line_endings('0-pythagoras', '0-pythagoras_converted')
