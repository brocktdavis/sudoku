.DEFAULT_GOAL := all
TGT_DIR       := /source

# Run docker interactive session
docker:
	docker run -it -v ${CURDIR}:${TGT_DIR} -w ${TGT_DIR} btdavis/sudoku

SRC_FILES := *.cs

run: $(SRC_FILES)
	dotnet run

all: run
