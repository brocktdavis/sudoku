.DEFAULT_GOAL := all
SHELL		  := bash
TGT_DIR       := /source

docker:
	docker run -it -v ${CURDIR}:${TGT_DIR} -w ${TGT_DIR} btdavis/sudoku