LOCAL_PATH := $(call my-dir)
include $(CLEAR_VARS)

LOCAL_MODULE := CppToUnity
LOCAL_SRC_FILES := CppToUnity.cpp

include $(BUILD_SHARED_LIBRARY)